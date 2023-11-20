using DataAccessLayer.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public struct RevenueByDate
    {
        public DateTime Date { get; set; }
        public double Total { get; set; }
    }
    public struct TopProducts
    {
        public string dish { get; set; }
        public int quantity { get; set; }
    }
    public class InicioDA : ConnectionSql
    {
        //Atributos
        public double TotalRevenue { get; private set; }
        public int TotalSales { get; private set; }
        public int TotalProducts { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public List<TopProducts> TopProductsList { get; private set; }

        public InicioDA() { }

        //Metodo para obtener los datos del dashboard
        private void getDashboardValues()
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    try
                    {
                        command.CommandText = "SELECT SUM(Total) FROM Ventas WHERE CAST(FechaCierre AS DATE) = CAST(GETDATE() AS DATE)";
                        TotalRevenue = Convert.ToDouble(command.ExecuteScalar());

                        command.CommandText = "SELECT COUNT(VentaID) FROM Ventas WHERE CAST(FechaCierre AS DATE) = CAST(GETDATE() AS DATE) AND Estado = 'Completada'";
                        TotalSales = Convert.ToInt32(command.ExecuteScalar());

                        command.CommandText = "SELECT COUNT(ProductoID) FROM Productos WHERE Estado = 'Activo'";
                        TotalProducts = Convert.ToInt32(command.ExecuteScalar());

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        //Metodo para obtener los datos y los labels del bar chart
        private void GetGrossRevenueList()
        {
            GrossRevenueList = new List<RevenueByDate>();
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;

                    command.CommandText = @"SELECT FechaCierre, SUM(Total) FROM Ventas WHERE FechaCierre BETWEEN DATEADD(DAY, -7, GETDATE()) AND GETDATE() GROUP BY FechaCierre";
                    
                    SqlDataReader reader = command.ExecuteReader();
                    
                    RevenueByDate result = new RevenueByDate();

                    while (reader.Read())
                    {
                        result.Date = (DateTime)reader[0];
                        result.Total = Convert.ToDouble(reader[1]);

                        GrossRevenueList.Add(result);
                    }

                    reader.Close();
                }
            }
        }

        //Metodo para obtener los datos del top productos mas vendidos
        private void GetTopProductsList()
        {
            TopProductsList = new List<TopProducts>();
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;

                    command.CommandText = "SELECT TOP 5 P.NombreProducto, SUM(DV.Cantidad) AS TotalCantidad FROM DetalleVenta DV INNER JOIN Productos P ON P.ProductoID = DV.ProductoID INNER JOIN Ventas V ON V.VentaID = DV.VentaID WHERE CAST(V.FechaCierre AS DATE) = CAST(GETDATE() AS DATE) GROUP BY P.NombreProducto ORDER BY TotalCantidad DESC;";
                    SqlDataReader reader = command.ExecuteReader();

                    TopProducts result = new TopProducts();

                    while (reader.Read())
                    {
                        result.dish = reader[0].ToString();
                        result.quantity = Convert.ToInt32(reader[1]);

                        TopProductsList.Add(result);
                    }

                    reader.Close();
                }
            }
        }

        //Metodo para actualizar todos los datos del dashboard
        public void LoadData()
        {
            getDashboardValues();
            GetGrossRevenueList();
            GetTopProductsList();
        }

    }
}
