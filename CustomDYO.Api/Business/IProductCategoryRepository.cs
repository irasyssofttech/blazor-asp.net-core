using CustomDYO.Api.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomDYO.Api.Model
{
    public interface IProductCategoryRepository
    {
        #region To get all product category
        Task<IEnumerable<ProductCatagory>> GetProductCategory();

        List<MainCategory> spGetProductCategory();
        #endregion

        #region To get product category for particular id

        Task<IEnumerable<ProductCatagory>> GetProductCategoryByID(int ProductCategoryID);
        #endregion

        #region To get the AdminDropdown.
        Task<IEnumerable<Wmsuser>> GetAdminUser(string RoleName);
        #endregion

        #region To add new product category
        ProductCatagory PostProductCategory(ProductCatagory productcategory);
        #endregion

        #region To update the particular product category.
        ProductCatagory PutProductCategory(ProductCatagory productcategory);
        #endregion

        #region  To get static dropdown list
        string GetCustomerDrop(int CustomerID);
        #endregion

        bool DeleteCategory(List<ListCheck> listChecks);
    }
}
