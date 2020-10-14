using CustomDYOClient.Model;
using CustomDYOClient.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomDYOClient.Pages
{
    public class ProductCategoryBase : ComponentBase
    {
        #region Global Variable
        [Inject]
        public IProductCategoryServices ProductCategoryServices { get; set; }

        public IEnumerable<ProductCatagory> productcategory { get; set; }

        public IEnumerable<ProductCatagory> parentcategory { get; set; }

        public IEnumerable<Wmsuser> AdminUser { get; set; }

        public IEnumerable<MainCategory> MainCategory { get; set; }

        public ProductCatagory Category { get; set; } = new ProductCatagory();

        [Parameter]

        public string CustomerID { get; set; }
        public string ParentID { get; set; }
        public string StaticDropG { get; set; }

        public bool IsDisabled { get; set; }

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected string imageDataURL;
        #endregion

        #region Pageload
        protected override async Task OnInitializedAsync()
        {
            try
            {
                productcategory = (await ProductCategoryServices.GetProductCategory()).ToList();
                await GetCategoriesAsync();
                foreach (var i in productcategory)
                {
                    i.IconFilePath = "http://localhost:58375/Files/productcategory/" + i.IconFilePath;
                }
                Saved = false;
            }
            catch (Exception)
            {
                StatusClass = "alert-danger";
                Message = "Something went wrong, to load the page.";
                Saved = true;

            }
        }
        #endregion

        #region GetCustomerDropdown
        protected async Task GetAdminUser(string value)
        {
            try
            {
                StaticDropG = value;
                AdminUser = (await ProductCategoryServices.GetAdminUser(value.ToString())).ToList();
            }
            catch (Exception)
            {
                StatusClass = "alert-danger";
                Message = "Something went wrong, to load the user";
                Saved = true;
            }
        }

        #endregion

        #region GetParentDropdown
        protected void GetParentCategory(string e)
        {
            try
            {
                CustomerID = e;
                int CustomerId = Convert.ToInt32(e.ToString());
                parentcategory = (productcategory.Where(x => x.CustomerId == CustomerId)).ToList();
            }
            catch (Exception)
            {
                StatusClass = "alert-danger";
                Message = "Something went wrong, to load the parentcategory";
                Saved = true;
            }
        }

        #endregion


        public async Task GetCategoriesAsync()
        {
            try
            {
                MainCategory = (await ProductCategoryServices.GetMainCategory()).ToList();
                foreach (var i in MainCategory)

                {
                    i.MainCtgyPath = "http://localhost:58375/Files/productcategory/" + i.MainCtgyPath;
                    foreach (var _ in i._Category)
                    {
                        _._CtgyPath = "http://localhost:58375/Files/productcategory/" + _._CtgyPath;
                        foreach (var __ in _.__Category)
                        {
                            __.__CtgyPath = "http://localhost:58375/Files/productcategory/" + __.__CtgyPath;
                            foreach (var ___ in __.___Category)
                            {
                                ___.___CtgyPath = "http://localhost:58375/Files/productcategory/" + ___.___CtgyPath;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                StatusClass = "alert-danger";
                Message = "Something went wrong, to load the parentcategory";
                Saved = true;
            }
        }
        protected void GetParentID(string e)
        {
            ParentID = e;
        }

        #region SaveButton code
        protected async Task HandleValidSubmit()
        {
            try
            {
                Category.ParentId = Convert.ToInt32(ParentID);
                Category.CustomerId = Convert.ToInt32(CustomerID);
                Category.IconFilePath = imageDataURL;
                if (Category.CustomerId > 0)
                {
                    if (Category.ProductCatagoryId == 0) //new
                    {
                        var addedEmployee = await ProductCategoryServices.PostCategory(Category);
                        if (addedEmployee.ProductCatagoryId != 0)
                        {
                            await OnInitializedAsync();
                            StatusClass = "alert-success";
                            Message = "New employee added successfully.";
                            Saved = true;

                        }
                        else
                        {
                            StatusClass = "alert-danger";
                            Message = "Something went wrong. Please try again.";
                            Saved = true;
                        }
                    }
                    else
                    {
                        var updateCategory = await ProductCategoryServices.PutCategory(Category);
                        if (updateCategory.ProductCatagoryId != 0)
                        {
                            await OnInitializedAsync();
                            StatusClass = "alert-success";
                            Message = " employee Update successfully.";
                            Saved = true;
                        }
                        else
                        {
                            StatusClass = "alert-danger";
                            Message = "Something went wrong. Please try again.";
                            Saved = true;
                        }
                    }             
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong, please check the fields";
                    Saved = true;
                }
            }
            catch (Exception)
            {
                StatusClass = "alert-danger";
                Message = "Something went wrong, to adding/updating the employee.";
                Saved = true;
            }
        }
        #endregion

        #region HandleInvalidSubmit Handle code
        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
            Saved = true;
        }
        #endregion

        #region Reset Form
        protected void ResetForm()
        {
            Category = new ProductCatagory();
            Saved = false;
            CustomerID = "-1";
            ParentID = "-1";
            StaticDropG = "-1";
            imageDataURL = string.Empty;
            IsDisabled = false;
        }
        #endregion

        #region Edit Button Event
        protected async void EditCategory(int ID)
        {
            IsDisabled = true;
            Category = productcategory.Where(x => x.ProductCatagoryId == ID).FirstOrDefault();
            imageDataURL = Category.IconFilePath;
            StaticDropG = "Customer";
            AdminUser = (await ProductCategoryServices.GetAdminUser(StaticDropG.ToString())).ToList();
            CustomerID = Category.CustomerId.ToString();
            parentcategory = (productcategory.Where(x => x.CustomerId == (Category.CustomerId))).ToList();
            ParentID = Category.ParentId.ToString();
            imageDataURL = Category.IconFilePath;
        }
        #endregion 
        public List<_Checkbox> ClubMember { get; set; } = new List<_Checkbox>();
        public List<ListCheck> CheckList { get; set; } = new List<ListCheck>();

        protected void CheckedChnaged(int clubID)
        {
            try
            {
                bool flag = false;
                if (ClubMember.Count > 0)
                {
                    foreach (var i in ClubMember)
                    {
                        if (i.CategoryID == clubID)
                        {
                            if (i.Status == true)
                            {
                                i.Status = false;
                                flag = true;
                            }
                            else
                            {
                                i.Status = true;
                                flag = true;
                            }
                        }
                    }
                    if (flag == false)
                    {
                        _Checkbox obj = new _Checkbox();
                        obj.CategoryID = clubID;
                        obj.Status = true;
                        ClubMember.Add(obj);
                    }

                }
                else
                {
                    _Checkbox obj = new _Checkbox();
                    obj.CategoryID = clubID;
                    obj.Status = true;
                    ClubMember.Add(obj);
                }
            }
            catch (Exception)
            {
                StatusClass = "alert-danger";
                Message = "Something went wrong, to select the category to delete.";
                Saved = true;
            }
        }

        protected async void DeleteCategory()
        {
            try
            {
                if (ClubMember.Count > 0)
                {
                    foreach (var i in ClubMember)
                    {
                        if (i.Status == true)
                        {
                            ListCheck obj = new ListCheck();
                            obj.CategoryID = i.CategoryID;
                            CheckList.Add(obj);
                        }
                    }
                }
                var result = await ProductCategoryServices.DeleteCategory(CheckList);
                if (result == true)
                {
                    ResetForm();
                    await OnInitializedAsync();
                    StatusClass = "alert-success";
                    Message = "Category Delete";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong, to Delete the Category";
                    Saved = true;
                }
            }
            catch (Exception)
            {
                StatusClass = "alert-danger";
                Message = "Something went wrong, to Delete the Category";
                Saved = true;
            }
        }

    }
}
