using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLayer.Models;

namespace FOOD
{
    public partial class Productos : Form
    {
        ProductosModel menuModel = new ProductosModel();
        public Productos()
        {
            InitializeComponent();
        }

        private void btnAgregarPlatillo_Click(object sender, EventArgs e)
        {
            ProductosCU createProduct = new ProductosCU();
            createProduct.lblTitulo.Text = "Agregar producto";
            createProduct.FormClosed += updateDgv;
            createProduct.ShowDialog();
        }

        //Metodo para mostrar el menu en el DGV
        private void showProducts()
        {
            dgvMenu.Rows.Clear();
            DataTable dt = menuModel.showProducts();

            foreach (DataRow row in dt.Rows) 
            {
                string state = row["Estado"].ToString();
                Image pointImage;

                if (state == "Activo") pointImage = Properties.Resources.greenpoint;
                else pointImage = Properties.Resources.greypoint;

                dgvMenu.Rows.Add(row["ProductoID"], row["NombreProducto"], $"$ {row["Precio"]}", row["Existencias"], pointImage, state);
            }
        }

        //Metodo para actualizar el DGV cuando se cierre la ventana de crear/actualizar menu
        private void updateDgv(object sender, FormClosedEventArgs e)
        {
            showProducts();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            showProducts();
            cbFiltro.SelectedIndex = 0;
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvMenu.Columns[e.ColumnIndex].Name;
            string productID = dgvMenu.Rows[e.RowIndex].Cells["dishID"].Value.ToString();

            //Editar platillo con el ID seleccionado
            if(colName == "editar")
            {
                ProductosCU updateProduct = new ProductosCU();

                //Se guardan y muestran los datos del registro del menu que se quiere actualizar
                DataTable dt = menuModel.getProduct(productID, "");
                DataRow row = dt.Rows[0];

                updateProduct.lblTitulo.Text = "Editar producto";
                updateProduct.lblPlatilloID.Text = productID.PadLeft(6, '0');
                updateProduct.lblPlatilloID.Visible = true;

                updateProduct.txtNombre.Text = row["NombreProducto"].ToString();
                updateProduct.txtDescripcion.Text = row["DescripcionProducto"].ToString();
                updateProduct.txtPrecio.Text = row["Precio"].ToString();
                updateProduct.txtExistencias.Text = row["Existencias"].ToString();

                switch (row["Estado"])
                {
                    case "Activo":
                        updateProduct.tsActive.Checked = true;
                        break;
                    case "Inactivo":
                        updateProduct.tsActive.Checked = false;
                        break;
                }

                updateProduct.FormClosed += updateDgv;
                updateProduct.ShowDialog();
            }
        }

        private void txtFiltrar_TextChange(object sender, EventArgs e)
        {
            string filter = txtFiltrar.Text;
            dgvMenu.SuspendLayout();

            foreach (DataGridViewRow row in dgvMenu.Rows)
            {
                //Restablecer la visibilidad de todas las filas
                row.Visible = true;

                if (!string.IsNullOrEmpty(filter))
                {
                    //Verificar si alguna celda contiene el filtro
                    bool filterExist = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            filterExist = true;
                            break;
                        }
                    }

                    //Si no exite ninguna coincidencia con el filtro, la fila se oculta
                    if (!filterExist)
                    {
                        row.Visible = false;
                    }
                }
            }

            dgvMenu.ResumeLayout();
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cbFiltro.Text;

            dgvMenu.SuspendLayout();

            foreach (DataGridViewRow row in dgvMenu.Rows)
            {
                //Restablecer la visibilidad de todas las filas
                row.Visible = true;

                if (filter != "Todos")
                {
                    //verificar si la celda Estado contiene el filtro
                    bool filterExist = false;

                    if (row.Cells["Estado"].Value.ToString() == filter)
                    {
                        filterExist = true;
                    }

                    if (!filterExist)
                    {
                        row.Visible = false;
                    }
                }
            }

            dgvMenu.ResumeLayout();
        }
    }
}
