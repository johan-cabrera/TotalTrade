using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Connection;

namespace DataAccessLayer.Entities
{
    public class ProductosDA : ConnectionSql
    {
        DataTable products = new DataTable();

        //Metodo para obtener los datos de la tabla Menu
        public DataTable showProducts()
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand()) 
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Productos ORDER BY ProductoID DESC";

                    SqlDataReader reader = command.ExecuteReader();

                    products.Clear();
                    products.Load(reader);
                    return products;
                }
            }
        }

        //Metodo que inserta un registro al menu
        public void insertProduct(string name, string description, string state, double price, int stock)
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Productos (NombreProducto, DescripcionProducto, Estado, Precio, Existencias) VALUES (@name, @description, @state, @price, @stock)";

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@stock", stock);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo que obtiene el valor de un registro del menu en especifico
        public DataTable getProduct(string dishID, string dishName) 
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Productos WHERE ProductoID = @id OR NombreProducto = @Name";

                    command.Parameters.AddWithValue("@id", dishID);
                    command.Parameters.AddWithValue("@name", dishName);

                    SqlDataReader reader = command.ExecuteReader();

                    products.Clear();
                    products.Load(reader);
                    return products;
                }
            }
        }

        //Metodo que actualiza el valor de un registro del menu
        public void updateProduct(int id, string name, string description, string state, double price, int stock)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "UPDATE Productos SET NombreProducto = @name, DescripcionProducto = @description, Estado = @state, Precio = @price, Existencias = @stock WHERE ProductoID = @id";

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@stock", stock);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
