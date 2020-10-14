using CustomDYO.Api.DataAccess;
using CustomDYO.Api.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomDYO.Api.Controllers
{
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    [Route("api/[controller]")]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoryRepository productCategoryRepository;
        public ProductCategoryController(IProductCategoryRepository productCategoryRepository)
        {
            this.productCategoryRepository = productCategoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetProductCategory()
        {
            try
            {
              return Ok(await productCategoryRepository.GetProductCategory());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }


        [HttpGet]
        [Route("GetMainCategory")]

        public ActionResult GetMainCategory()
        {
            try
            {
                return Ok(productCategoryRepository.spGetProductCategory());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        //[HttpGet]
        //public string GetCustomerDrop(int CustomerID)
        //{
        //    var result = productCategoryRepository.GetCustomerDrop(CustomerID);
        //    return "dfgdg";
        //}

        [HttpGet("{RoleName}")] 
        public async Task<ActionResult> GetAdminUser(string RoleName)
        {
            try
            {            
                return Ok(await productCategoryRepository.GetAdminUser(RoleName));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public ProductCatagory PostProductCategory([FromBody] ProductCatagory productcategory)
        {
            try
            {
                if (productcategory == null)
                    return new ProductCatagory();

                if (productcategory.CatagoryName == string.Empty || productcategory.CustomerId == 0)
                {
                    return new ProductCatagory();
                }

                if (!ModelState.IsValid)
                {
                    return new ProductCatagory();
                }
                else
                {

                    var createdCategory = productCategoryRepository.PostProductCategory(productcategory);
                    if (createdCategory.ProductCatagoryId != 0)
                    {
                        return createdCategory;
                    }
                    else
                    {
                        return new ProductCatagory();
                    }
                }
            }
            catch (Exception)
            {
                return  new ProductCatagory();
            }
        }

        [HttpPut]
        public ProductCatagory PutProductCategory([FromBody] ProductCatagory productcategory)
        {
            if (productcategory == null)
                return new ProductCatagory();

            var Categorytoupdate = productCategoryRepository.GetProductCategoryByID(productcategory.ProductCatagoryId);

            if (Categorytoupdate == null)
            {
                return new ProductCatagory();
            }
            else
            {
                var updatecategory = productCategoryRepository.PutProductCategory(productcategory);
                if (updatecategory.ProductCatagoryId != 0)
                {
                    return updatecategory;
                }
                else
                {
                    return new ProductCatagory();
                }
            }
        }

        [HttpDelete]
        public bool DeleteProductCategoryAsync([FromBody] List<ListCheck> _listCheck)
        {
            try
            {
                if (_listCheck.Count > 0)
                {
                    var result = productCategoryRepository.DeleteCategory(_listCheck);
                    if (result == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
