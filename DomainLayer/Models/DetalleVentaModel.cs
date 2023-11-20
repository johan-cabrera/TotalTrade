using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DomainLayer.Models
{
    public class DetalleVentaModel
    {
        private DetalleVentaDA saleDetailDA = new DetalleVentaDA();
        private ProductosDA menuDA = new ProductosDA();

        //Metodo que recibe y retorna el detalle de las ordenes
        public DataTable showSaleDetails(string saleID)
        {
            DataTable orderDetails = new DataTable();
            orderDetails = saleDetailDA.showSaleDetails(int.Parse(saleID));
            return orderDetails;
        }

        //Metodo que da formato a los datos y los manda a insertar
        public bool insertSaleDetail(string orderID, string product, string quantityS)
        { 
            bool validate;
            int quantity, stock, productID;
            double unitPrice;

            DataTable productValues = new DataTable();
            productValues = menuDA.getProduct("", product);
            if(productValues.Rows.Count != 0)
            {
                DataRow row = productValues.Rows[0];

                

                productID = int.Parse(row["ProductoID"].ToString());
                unitPrice = double.Parse(row["Precio"].ToString());
                stock = int.Parse(row["Existencias"].ToString());

                validate = int.TryParse(quantityS, out quantity);

                if (stock < quantity) return false;

                if (validate)
                {
                    saleDetailDA.insertSaleDetail(int.Parse(orderID), productID, quantity, unitPrice);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
            

        }

        //Metodo que elimina un registro de la tabla detalle orden
        public void deleteSaleDetail(string saleDetailID)
        {
            saleDetailDA.deleteSaleDetail(int.Parse(saleDetailID));
        }
    }
}
