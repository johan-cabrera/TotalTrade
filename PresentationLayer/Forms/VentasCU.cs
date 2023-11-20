using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOOD
{
    public partial class VentasCU : Form
    {
        ProductosModel productsModel = new ProductosModel();
        DetalleVentaModel detalleVentaModel = new DetalleVentaModel();
        VentasModel salesModel = new VentasModel();


        public VentasCU()
        {
            InitializeComponent();
            clearTxt();
        }

        //Importar metodos que permiten mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrdenesCU_Load(object sender, EventArgs e)
        {
            if(int.Parse(lblVentaID.Text)  == 0) 
            {
                int saleID = salesModel.inserSale();
                lblVentaID.Text = saleID.ToString().PadLeft(6, '0');
            }
            
            loadProducts();
            showOrderDetails();
        }

        //Metodo para llenar el auto complete de los platillos
        private void loadProducts()
        {
            AutoCompleteStringCollection products = new AutoCompleteStringCollection();
            DataTable dt = productsModel.showProducts();

            foreach (DataRow row in dt.Rows)
            {
                if (row["Estado"].ToString() == "Activo")
                {
                    products.Add(row["NombreProducto"].ToString());
                }                
            }

            txtProducto.AutoCompleteCustomSource = products;
        }

        private void panelDetalleOrden_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelOrden_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodo para mostrar los detalles de las ordenes en el DGV
        private void showOrderDetails()
        {
            string currentID = lblVentaID.Text;
            dgvDetalleVenta.Rows.Clear();

            DataTable dt = detalleVentaModel.showSaleDetails(currentID);

            foreach (DataRow row in dt.Rows)
            {
                dgvDetalleVenta.Rows.Add(row["DetalleVentaID"],row["NombreProducto"], row["Cantidad"], row["PrecioUnitario"]);
            }
        }

        private void btnAgregarDetalleOrden_Click(object sender, EventArgs e)
        {
            string saleID, productName, quantity;
            bool actionsuccess;
            saleID = lblVentaID.Text;
            productName = txtProducto.Text;
            quantity = txtCantidad.Text;

            if (txtProducto.Enabled == true)
            {

                actionsuccess = detalleVentaModel.insertSaleDetail(saleID, productName, quantity);

                if (actionsuccess)
                {
                    MessageBox.Show("El Detalle fue agregado");
                    getTotal(saleID);
                    showOrderDetails();
                    clearTxt();
                }
                else
                {
                    MessageBox.Show($"No se encontraron existencias suficientes de {productName} en stock", "Error");
                }
            }
            else
            {
                txtProducto.Text = string.Empty;
                txtCantidad.Text = string.Empty;

                txtProducto.Enabled = true;
                txtCantidad.Enabled = true;
            }
            


        }

        private void getTotal(string saleID)
        {
            DataTable dt = salesModel.getSale(saleID);
            DataRow row = dt.Rows[0];


            lblTotal.Text = row["Total"].ToString();
        }

        //Metodo para limpiar los textbox
        private void clearTxt()
        {
            txtProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        private void dgvDetalleOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dgvDetalleVenta.Columns[e.ColumnIndex].Name;
            string orderDetailID = dgvDetalleVenta.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string productName = dgvDetalleVenta.Rows[e.RowIndex].Cells["dish"].Value.ToString();
            string quantity = dgvDetalleVenta.Rows[e.RowIndex].Cells["quantity"].Value.ToString();


            //Seleccionar valores de la fila seleccionada
            if (colName == "ver")
            {
                txtProducto.Text = productName;
                txtCantidad.Text = quantity;

                txtProducto.Enabled = false;
                txtCantidad.Enabled = false;
            }
            else if(colName == "eliminar")
            {
                if (!btnAgregarDetalleOrden.Enabled) return;
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    detalleVentaModel.deleteSaleDetail(orderDetailID);
                    getTotal(lblVentaID.Text);
                    showOrderDetails();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DataTable dt = salesModel.getSale(lblVentaID.Text);
            DataRow row = dt.Rows[0];

            if (row["Estado"].ToString() == "Completada")
            {
                MessageBox.Show("La venta ya fue cancelada.", "Advertencia");
                return;
            }
            VentasP pay = new VentasP();
            pay.lblVentaID.Text = this.lblVentaID.Text;
            pay.lblTotal.Text = this.lblTotal.Text;
            pay.FormClosed += ispayed;
            pay.ShowDialog();
        }

        private void ispayed(object sender, FormClosedEventArgs e)
        {
            string saleID = lblVentaID.Text;
            DataTable dt = salesModel.getSale(saleID);
            DataRow row = dt.Rows[0];

            if (row["Estado"].ToString() == "Completada" || row["Estado"].ToString() == "Descartada")
            {
                btnAgregarDetalleOrden.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }
    }
}
