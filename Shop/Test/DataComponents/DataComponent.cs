using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProductClassLibrary;

namespace Products
{
    public class DataComponent
    {


        static string CONNECTIONSTRING = @"Data Source=RILPT184;Initial Catalog=Boutique_Shop;User ID=sa;Password=sa123";
        public void AddNewProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                var query = "INSERT INTO Product VALUES(@Code,@Name,@Brand,@Category,@Size,@Price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Code", product.DressCode);
                cmd.Parameters.AddWithValue("@Name", product.DressName);
                cmd.Parameters.AddWithValue("@Brand", product.Brand);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Size", product.DressSize);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Details not added!");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public object FindProduct(int dressCode)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int Code)
        {
            Product product = new Product();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Product WHERE DressCode  = " + Code;
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows == 0)
                        throw new Exception("Cannot Delete Product");
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void UpdateProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                var query = $"UPDATE Product set DressName = '{ product.DressName }', Brand = '{product.Brand}', Category = '{product.Category},DressSize = '{product.DressSize}' , Price = '{product.Price}'" +
                    $"" +
                    $" WHERE DressCode = {product.DressCode}";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("No Details were updated");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
