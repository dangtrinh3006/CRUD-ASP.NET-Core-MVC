using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales_Order.Models;
using Sales_Order.Utility;
using System.Data.SqlClient;
using System.Data;

namespace Sales_Order.Data
{
    public class SalesDAL
    {
        string connectionString = ConnectionStringg.CName;

        public IEnumerable<Sales> GetAllSalesOrder()
        {
            List<Sales> lstsales = new List<Sales>();
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("sp_ViewSalesOrders", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read()) 
                {
                    Sales sale = new Sales();
                    sale.ID = Convert.ToInt32(reader["ID"]);
                    sale.SalesOrder = reader["SalesOrder"].ToString();
                    sale.SalesOrderItem = reader["SalesOrderItem"].ToString();
                    sale.WorkOrder = reader["WorkOrder"].ToString();
                    sale.ProductID = reader["ProductID"].ToString();
                    sale.ProductDescription = reader["ProductDescription"].ToString();
                    sale.OrderQuantity = reader.GetDecimal(reader.GetOrdinal("OrderQuantity"));
                    sale.OrderStatus = reader["OrderStatus"].ToString();
                    sale.Timestamp = DateTime.Parse(reader["Timestamp"].ToString());
                    lstsales.Add(sale);
                }
                con.Close();
            }
            return lstsales;
        }

        public void AddSalesOrder(Sales sale)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("sp_InsertSalesOrder", con);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@SalesOrder", sale.SalesOrder);
                sqlCommand.Parameters.AddWithValue("@SalesOrderItem", sale.SalesOrderItem);
                sqlCommand.Parameters.AddWithValue("@WorkOrder", sale.WorkOrder);
                sqlCommand.Parameters.AddWithValue("@ProductID", sale.ProductID);
                sqlCommand.Parameters.AddWithValue("@ProductDescription", sale.ProductDescription);
                sqlCommand.Parameters.AddWithValue("@OrderQuantity", sale.OrderQuantity);
                sqlCommand.Parameters.AddWithValue("@OrderStatus", sale.OrderStatus);

                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateSalesOrder(Sales sale)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("sp_UpdateSalesOrder", con); 
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@ID", sale.ID);
                sqlCommand.Parameters.AddWithValue("@SalesOrder", sale.SalesOrder);
                sqlCommand.Parameters.AddWithValue("@SalesOrderItem", sale.SalesOrderItem);
                sqlCommand.Parameters.AddWithValue("@WorkOrder", sale.WorkOrder);
                sqlCommand.Parameters.AddWithValue("@ProductID", sale.ProductID);
                sqlCommand.Parameters.AddWithValue("@ProductDescription", sale.ProductDescription);
                sqlCommand.Parameters.AddWithValue("@OrderQuantity", sale.OrderQuantity);
                sqlCommand.Parameters.AddWithValue("@OrderStatus", sale.OrderStatus);

                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteSalesOrder(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("sp_DeleteSalesOrder", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID", id);
               
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        public Sales GetSalesOrdersData(int? id)
        {
            Sales sale = new Sales();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SalesOrderTable WHERE ID = @ID";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@ID", id);

                con.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    sale.ID = Convert.ToInt32(reader["ID"]);
                    sale.SalesOrder = reader["SalesOrder"].ToString();
                    sale.SalesOrderItem = reader["SalesOrderItem"].ToString();
                    sale.WorkOrder = reader["WorkOrder"].ToString();
                    sale.ProductID = reader["ProductID"].ToString();
                    sale.ProductDescription = reader["ProductDescription"].ToString();
                    sale.OrderQuantity = Convert.ToInt32(reader["OrderQuantity"]);
                    sale.OrderStatus = reader["OrderStatus"].ToString();
                    sale.Timestamp = DateTime.Parse(reader["Timestamp"].ToString());
                }
                con.Close();
            }
            return sale;
        }
    }
}
