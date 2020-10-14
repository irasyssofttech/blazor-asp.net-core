using CustomDYOClient.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomDYOClient.Services
{
    public interface IProductCategoryServices
    {
        #region Get Product
        Task<IEnumerable<ProductCatagory>> GetProductCategory();
        Task<IEnumerable<MainCategory>> GetMainCategory();
        #endregion

        #region GetAdminDropdown
        Task<IEnumerable<Wmsuser>> GetAdminUser(string RoleName);
        #endregion

        #region PostCategory
        Task<ProductCatagory> PostCategory(ProductCatagory productcategory);
        #endregion

        #region PutCategory
        Task<ProductCatagory> PutCategory(ProductCatagory productcategory);
        #endregion

        Task<string> GetCustomerDrop(int CustomerID);

        Task<bool> DeleteCategory(List<ListCheck> _listCategory);
    }
}
