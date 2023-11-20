using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOOD
{
    public partial class Ventas : Form
    {
        VentasModel salesModel = new VentasModel();
        DataTable receipt;
        DataTable sale;
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {

            VentasCU createOrder = new VentasCU();
            createOrder.lblTitulo.Text = "VENTA:";
            createOrder.FormClosed += updateDgv;
            createOrder.ShowDialog();
        }

        //Metodo para actualizar el DGV cuando se cierre la ventana de crear/actualizar menu
        private void updateDgv(object sender, FormClosedEventArgs e)
        {
            showSales();
            addFilter();
        }

        //Metodo para mostrar las ordenes en el DGV
        private void showSales()
        {
            dgvVentas.Rows.Clear();
            DataTable dt = salesModel.showSales();

            foreach (DataRow row in dt.Rows) 
            { 
                string state = row["Estado"].ToString();
                DateTime date = (DateTime)row["FechaCierre"];
                Image pointImage;

                if (state == "Completada") pointImage = Properties.Resources.greenpoint;
                else if (state == "En Proceso") pointImage = Properties.Resources.yellowpoint;
                else pointImage = Properties.Resources.greypoint;

                dgvVentas.Rows.Add(row["VentaID"], date.ToString("dd-MM-yyyy"), $"$ {row["Total"]}", pointImage, row["Estado"]);
            }
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            showSales();
            cbFiltro.SelectedIndex = 0;
        }

        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvVentas.Columns[e.ColumnIndex].Name;
            string saleID = dgvVentas.Rows[e.RowIndex].Cells["saleID"].Value.ToString();
            string state = dgvVentas.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            string total = dgvVentas.Rows[e.RowIndex].Cells["Total"].Value.ToString();

            if (colName == "editar")
            {
                
                VentasCU updateSale = new VentasCU();

                updateSale.lblTotal.Text = total;
                updateSale.lblVentaID.Text = saleID.PadLeft(6, '0');

                if (state == "Completada" || state == "Descartada")
                {
                    updateSale.btnAgregarDetalleOrden.Enabled = false;
                    updateSale.btnCancelar.Enabled = false;
                }
                updateSale.FormClosed += updateDgv;
                updateSale.ShowDialog();
                
            }
            if (colName == "imprimir")
            {
                receipt = salesModel.receiptSale(saleID);
                sale = salesModel.getSale(saleID);



                pdRecibo.Print();
                ppdRecibo.Document = pdRecibo;
                ppdRecibo.ShowDialog();
            }
            if(colName == "eliminar")
            {
                DialogResult result = MessageBox.Show($"¿Esta seguro que desea descartar la venta: {saleID}?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    salesModel.updateSale(saleID, "Descartada");
                    showSales();
                }
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            addFilter();
        }


        private void txtFiltro_TextChange(object sender, EventArgs e)
        {
            string filter = txtFiltro.Text;
            dgvVentas.SuspendLayout();

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                //Restablecer la visibilidad de todas las filas
                row.Visible = true;

                if (!string.IsNullOrEmpty(filter))
                {
                    //Verificar si alguna celda contiene el filtro
                    bool filterExist = false;

                    if (row.Cells["orderID"].Value.ToString() == filter)
                    {
                        filterExist = true;
                    }

                    //Si no exite ninguna coincidencia con el filtro, la fila se oculta
                    if (!filterExist)
                    {
                        row.Visible = false;
                    }
                }
            }

            dgvVentas.ResumeLayout();
        }

        private void addFilter()
        {
            string filter = cbFiltro.Text;
            dgvVentas.SuspendLayout();

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                //Restablecer la visibilidad de todas las filas
                row.Visible = true;

                if (filter != "Todos")
                {
                    //verificar si la celda Estado contiene el filtro
                    bool filterExist = false;
                    string cellValue = row.Cells["Estado"].Value.ToString();
                    if (cellValue == filter)
                    {
                        filterExist = true;
                    }
                    else if (filter == "Activas" && (cellValue == "En Proceso" || cellValue == "Lista" || cellValue == "Servida"))
                    {
                        filterExist = true;
                    }

                    if (!filterExist)
                    {
                        row.Visible = false;
                    }
                }
            }

            dgvVentas.ResumeLayout();
        }

        private void pdRecibo_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataRow saleRow = sale.Rows[0];

            string saleID = saleRow[0].ToString().PadLeft(6, '0');
            string date = Convert.ToDateTime(saleRow[2]).ToString("dd/MM/yyyy");
            string total = $"${saleRow[3]}".PadLeft(6);

            string receiptString;

            receiptString =  "             TOTAL TRADE\n";
            receiptString += "        18 79, HIGH HOUSE RD\n";
            receiptString += "        NEW HILL, NC, 27513\n";
            receiptString += "         (503) 6192 - 1660\n\n";
            receiptString += $"VENTA: {saleID}".PadRight(28) + $"{date}";
            receiptString += "\n\nCANT " + "PRODUCTO".PadRight(24) + "SUB TOTAL".PadLeft(6);
            receiptString += "\n--------------------------------------";

            Font font = new Font("Courier New", 10, FontStyle.Regular, GraphicsUnit.Point);

            e.Graphics.DrawString(receiptString, font, Brushes.Black, 10, 50);

            int x = 10;
            int y = 190;
            foreach (DataRow row in receipt.Rows)
            {
                string cantidad = row[1].ToString().Substring(0, Math.Min(row[1].ToString().Length, 5)).PadRight(5);
                string producto = row[0].ToString().Substring(0, Math.Min(row[0].ToString().Length, 20)).ToUpper();
                string precio = $"${row[2]}".PadLeft(6);

                string filaRecibo = $"{cantidad}{producto}\n";

                e.Graphics.DrawString(filaRecibo, font, Brushes.Black, x, y);
                e.Graphics.DrawString(precio, font, Brushes.Black, x + 260, y);

                y += 20;
            }

            e.Graphics.DrawString("TOTAL:", font, Brushes.Black, x, y += 20);
            e.Graphics.DrawString(total, font, Brushes.Black, x + 260, y);

            pdRecibo.DefaultPageSettings.PaperSize = new PaperSize("Customsize", 350, y += 40);
        }
    }
}
