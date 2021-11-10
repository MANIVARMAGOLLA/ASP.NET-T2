using Activity2DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2DAL
{
    public class DAL
    {
        //Reference Variable : Class Level : Member Variables
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;
        SqlDataReader sqlDataReaderObj;
        public DAL()
        {
            sqlConObj = new SqlConnection();
            sqlCmdObj = new SqlCommand();

        }
        public List<ProductDTO> FetchProductByPrice()
        {
            try
            {
                //Setting up the connectionstring to the connection object
                sqlConObj.ConnectionString = ConfigurationManager.
                    ConnectionStrings["AdvWorksDBConnStr"].ConnectionString;
                //SEtting up the command text for the command object
                sqlCmdObj.CommandText = @"SELECT PRODUCTID,NAME,PRODUCTNUMBER FROM PRODUCTION.PRODUCT WHERE LISTPRICE >747.37;";
                sqlCmdObj.Connection = sqlConObj;

                //Execute
                sqlConObj.Open();//COnnection should be open not command
                sqlDataReaderObj = sqlCmdObj.ExecuteReader();
                List<ProductDTO> lstPro = new List<ProductDTO>();

                ProductDTO newepartObj = new ProductDTO();

                while (sqlDataReaderObj.Read())
                {


                    lstPro.Add(new ProductDTO()
                    {
                        ProductId = sqlDataReaderObj[0].ToString(),
                        ProductName = sqlDataReaderObj[1].ToString(),
                        ProductNumber = sqlDataReaderObj[2].ToString(),

                    });

                }
                return lstPro;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                sqlConObj.Close();
            }

        }



    }
}
