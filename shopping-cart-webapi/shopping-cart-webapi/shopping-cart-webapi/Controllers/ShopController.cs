using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using shopping_cart_webapi.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_cart_webapi.Controllers
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
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("ShoppingCon").ToString());
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblProducts;", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response response = new Response();

            if (dt.Rows.Count > 0) {
                for(int i = 0; i < dt.Rows.Count; i++) {
                    Products products = new Products();

                    products.Id = Convert.ToInt32(dt.Rows[i]["Id"]); 
                    products.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    products.Image = Convert.ToString(dt.Rows[i]["Image"]); 
                    products.ActualPrice = Convert.ToDecimal(dt.Rows[i]["ActualPrice"]); 
                    products.DiscountedPrice = Convert.ToDecimal(dt.Rows[i]["DiscountedPrice"]); 
                    lstproducts.Add(products);
                }
                if (lstproducts.Count > 0) {
                    response.StatusCode = 200;
                    response.StatusMessage = "Data Found";
                    response.listproducts = lstproducts;
                }
                else {
                    response.StatusCode = 100;
                    response.StatusMessage = "Data Not Found";
                    response.listproducts = null;
                }
            }
            else {
                response.StatusCode = 100;
                response.StatusMessage = "Data Not Found";
                response.listproducts = null ;
            
            }
            return response;
        }
    
    
    [HttpPost]
    [Route("AddProduct")]
    public Response AddProduct(Products products)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("ShoppingCon").ToString());
            Response response = new Response();
            if (products.Id > 0)
            {
                SqlCommand cmd = new SqlCommand("Insert into Cart(ProductId) Values('" + products.Id+"')", connection);
                connection.Open();
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                if (i > 0)
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "Item Added";
                }
                else
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "Item Added";
                }
            }
            else
            {
                response.StatusCode = 200;
                response.StatusMessage = "No Item Found";
            }
            return response;
        }



        [HttpGet]

        [Route("ProductListCart")]

        public Response ProductListCart()
        {

            List<Products> lstproducts = new List<Products>();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("ShoppingCon").ToString());
            SqlDataAdapter da = new SqlDataAdapter(" select P.ID, P.Name,P.Image,P.ActualPrice,P.DiscountedPrice from Cart C Inner Join tblProducts P  ON C.ProductId = P.ID;", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response response = new Response();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Products products = new Products();

                    products.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    products.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    products.Image = Convert.ToString(dt.Rows[i]["Image"]);
                    products.ActualPrice = Convert.ToDecimal(dt.Rows[i]["ActualPrice"]);
                    products.DiscountedPrice = Convert.ToDecimal(dt.Rows[i]["DiscountedPrice"]);
                    lstproducts.Add(products);
                }
                if (lstproducts.Count > 0)
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "Data Found";
                    response.listproducts = lstproducts;
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMessage = "Data Not Found";
                    response.listproducts = null;
                }
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "Data Not Found";
                response.listproducts = null;

            }
            return response;
        }
    }
}
