using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class VentasModel
    {
        private VentasDA salesDA = new VentasDA();

        //Metodo que recibe y retorna las ordenes
        public DataTable showSales()
        {
            DataTable sales = new DataTable();
            sales = salesDA.showSales();
            return sales;
        }

        //Metodo que manda a insertar un registro y devuelve el id generado
        public int inserSale()
        {
            return salesDA.insertSale();
        }

        //Metodo que obtiene el valor de un registro de las ordenes en especifico
        public DataTable getSale(string saleID)
        {
            DataTable sale = new DataTable();
            sale = salesDA.getOrder(int.Parse(saleID));
            return sale;
        }

        //Metodo que da formato a los datos y los manda a actualizar
        public bool updateSale(string saleID, string state)
        {
            salesDA.updateOrder(int.Parse(saleID), state);
            return true;

        }

        //Metodo que rebice los datos del recibo
        public DataTable receiptSale(string saleID)
        {
            DataTable receipt = new DataTable();
            receipt = salesDA.receiptSale(int.Parse(saleID));
            return receipt;
        }
    }
}
