using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Connection;
using System.Xml.Linq;

namespace DataAccessLayer.Entities
{
    public class DetalleVentaDA : ConnectionSql
    {
        DataTable detalleOrden = new DataTable();

        //Metodo para obtener los datos de la tabla DetalleOrden
        public DataTable showSaleDetails(int saleID)
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand()) 
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT P.NombreProducto, DV.DetalleVentaID, DV.Cantidad, DV.PrecioUnitario FROM DetalleVenta DV INNER JOIN Productos P ON P.ProductoID = DV.ProductoID WHERE VentaID = @id";

                    command.Parameters.AddWithValue("@id", saleID);
                    SqlDataReader reader = command.ExecuteReader();

                    detalleOrden.Clear();
                    detalleOrden.Load(reader);
                    return detalleOrden;
                }
            }
        }

        //Metodo que inserta un registro al detalle de las ordenes
        public void insertSaleDetail(int orderID, int productID, int quantity,  double unitPrice)
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO DetalleVenta (VentaID, ProductoID, Cantidad, PrecioUnitario) VALUES (@saleID, @productID, @quantity, @unitPrice)";

                    command.Parameters.AddWithValue("@saleID", orderID);
                    command.Parameters.AddWithValue("@productID", productID);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@unitPrice", unitPrice);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo que elimina un registro del detalle de las ordenes
        public void deleteSaleDetail(int detailSaleID)
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "DELETE FROM DetalleVenta WHERE DetalleVentaID = @id";

                    command.Parameters.AddWithValue("@id", detailSaleID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
