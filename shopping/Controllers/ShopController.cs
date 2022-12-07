using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using shopping.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ShopController(IConfiguration configuration) {
            _configuration = configuration;

        }
        [HttpGet]
        [Route("ProductList")]
        public Response GetAllProducts() {
            List<Products> lstproducts = new List<Products>();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from tblProducts;", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response response = new Response();
            if (dt.Rows.Count > 0) {
                for (int i = 0; i < dt.Rows.Count; i++) {
                    Products products = new Products();
                    products.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    products.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    products.Image = Convert.ToString(dt.Rows[i]["Image"]);
                    products.ActualPrice = Convert.ToDecimal(dt.Rows[i]["ActualPrice"]);
                    products.DiscountedPrice = Convert.ToDecimal(dt.Rows[i]["DiscountedPrice"]);
                    lstproducts.Add(products); 

                }
                if (lstproducts.Count >0) {
                    response.StatusCode = 200;
                    response.StatusMessage = "Data Found";
                    response.listproducts = lstproducts;
                    
                } else {
                    response.StatusCode = 100;
                    response.StatusMessage = "No Data Found";
                    response.listproducts = null;


                }

            } else {
                response.StatusCode = 100;
                response.StatusMessage = "No Data Found";
                response.listproducts =null;
 

            }
            return response;
        }
    }
}