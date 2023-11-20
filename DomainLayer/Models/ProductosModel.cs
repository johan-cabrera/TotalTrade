using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DomainLayer.Models
{
    public class ProductosModel
    {
        private ProductosDA productsDA = new ProductosDA();

        //Metodo que recibe y retorna el menu
        public DataTable showProducts()
        {
            DataTable menu = new DataTable();
            menu = productsDA.showProducts();
            return menu;
        }

        //Metodo que da formato a los datos y los manda a insetar
        public bool insertProduct(string name, string description, string state, string priceS, string stock)
        {
            bool validate;
            double price;

            validate = double.TryParse(priceS, out price);

            if (validate)
            {
                productsDA.insertProduct(name, description, state, price, int.Parse(stock));
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo que recibe y retorna los datos de un registro del menu en especifico
        public DataTable getProduct(string dishID, string dishName)
        {
            DataTable menu = new DataTable();
            menu = productsDA.getProduct(dishID, dishName);
            return menu;
        }

        //Metodo que da formato a los datos y los manda a actualizar
        public bool updateProduct(string id, string name, string description, string state, string priceS, string stock)
        {
            bool validate;
            double price;

            validate = double.TryParse(priceS, out price);
            if (validate)
            {
                productsDA.updateProduct(int.Parse(id), name, description, state, price, int.Parse(stock));
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
