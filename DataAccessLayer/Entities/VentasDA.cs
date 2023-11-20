using DataAccessLayer.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class VentasDA : ConnectionSql
    {
        DataTable ordenes = new DataTable();
        DataTable receipt = new DataTable();

        //Metodo para obtener los datos de la tabla ordenes
        public DataTable showSales()
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Ventas ORDER BY VentaID DESC";

                    SqlDataReader reader = command.ExecuteReader();

                    ordenes.Clear();
                    ordenes.Load(reader);
                    return ordenes;
                }
            }
        }

        //Metodo que inserta un registro a las ordenes
        public int insertSale()
        {
            int orderId;
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Ventas (Estado, FechaCierre, Total) VALUES ('En Proceso', GETDATE(), 0); SELECT SCOPE_IDENTITY();";

                    orderId = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return orderId;
        }

        //Metodo que obtiene el valor de un registro de las ordenes en especifico
        public DataTable getOrder(int saleID)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Ventas WHERE VentaID = @id";

                    command.Parameters.AddWithValue("@id", saleID);

                    SqlDataReader reader = command.ExecuteReader();

                    ordenes.Clear();
                    ordenes.Load(reader);
                    return ordenes;
                }
            }
        }

        public void updateOrder(int saleId, string state)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand()) 
                {
                    command.Connection = conn;
                    command.CommandText = "UPDATE Ventas SET Estado = @state WHERE VentaID = @saleId";

                    command.Parameters.AddWithValue("@saleId", saleId);
                    command.Parameters.AddWithValue("@state", state);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo para retornar detalles del recibo
        public DataTable receiptSale(int saleID)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT P.NombreProducto, DV.Cantidad, (DV.PrecioUnitario * DV.Cantidad) AS Precio FROM DetalleVenta DV INNER JOIN Productos P ON P.ProductoID = DV.ProductoID WHERE VentaID = @saleID";

                    command.Parameters.AddWithValue("@saleID", saleID);


                    SqlDataReader reader = command.ExecuteReader();

                    receipt.Clear();
                    receipt.Load(reader);
                    return receipt;
                }
            }
        }
    }
}
