using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomDYO.Api.DataAccess;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using System.Net.Http;

namespace CustomDYO.Api.Model
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly OrderGraphicsTestContext appDBContext;

        private readonly IWebHostEnvironment _hostingEnvironment;
        public ProductCategoryRepository(OrderGraphicsTestContext appDBContext, IWebHostEnvironment environment)
        {
            this.appDBContext = appDBContext;
            this._hostingEnvironment = environment;
        }

        public async Task<IEnumerable<ProductCatagory>> GetProductCategory()
        {
            return await appDBContext.ProductCatagory.ToListAsync();
        }


        public async Task<IEnumerable<ProductCatagory>> GetProductCategoryByID(int ProductCategoryID)
        {
            return await appDBContext.ProductCatagory.Where(x => x.ProductCatagoryId == ProductCategoryID).ToListAsync();
        }

        public async Task<IEnumerable<Wmsuser>> GetAdminUser(string RoleName)
        {
            var result = (from WUser in appDBContext.Wmsuser
                          join WUserRole in appDBContext.WmsuserRole on WUser.Id equals WUserRole.UserId
                          join WRole in appDBContext.Wmsrole on WUserRole.RoleId equals WRole.Id
                          where WRole.DisplayName == RoleName
                          select new Wmsuser()
                          {
                              Id = WUser.Id,
                              CompanyName = WUser.CompanyName
                          }).ToListAsync();

            return await result;
        }

        public ProductCatagory PostProductCategory(ProductCatagory productCatagory)
        {
            try
            {
                string imgstr = productCatagory.IconFilePath;
                productCatagory.IconFilePath = "";
                var addedEntity = appDBContext.ProductCatagory.Add(productCatagory);
                appDBContext.SaveChanges();

                string imgName = addedEntity.Entity.CatagoryName + "_" + addedEntity.Entity.ProductCatagoryId + ".png";
                string result = SaveImage(imgstr, imgName);

                var foundCategory = appDBContext.ProductCatagory.FirstOrDefault(e => e.ProductCatagoryId == productCatagory.ProductCatagoryId);
                foundCategory.IconFilePath = imgName;
                appDBContext.SaveChanges();
                return addedEntity.Entity;

            }
            catch (Exception)
            {
                return new ProductCatagory();
            }
        }

        public ProductCatagory PutProductCategory(ProductCatagory productCatagory)
        {
            try
            {
                var foundCategory = appDBContext.ProductCatagory.FirstOrDefault(e => e.ProductCatagoryId == productCatagory.ProductCatagoryId);

                if (foundCategory != null)
                {
                    foundCategory.CatagoryName = productCatagory.CatagoryName;
                    foundCategory.ProductCategoryCode = productCatagory.ProductCategoryCode;
                    foundCategory.CatagoryDisplay = productCatagory.CatagoryDisplay;
                    foundCategory.CustomerId = productCatagory.CustomerId;
                    foundCategory.ParentId = productCatagory.ParentId;

                    string imgstr = productCatagory.IconFilePath;
                    productCatagory.IconFilePath = "";
                    string imgName = foundCategory.CatagoryName + "_" + foundCategory.ProductCatagoryId + ".png";
                    string result = SaveImage(imgstr, imgName);

                    appDBContext.SaveChanges();

                    return foundCategory;

                }

                return new ProductCatagory();
            }
            catch (Exception)
            {
                return new ProductCatagory();
            }
        }

        public string GetCustomerDrop(int CustomerID)
        {
            if (CustomerID != 0)
            {

                //var result = (from WUser in appDBContext.Wmsuser
                //              join WUserRole in appDBContext.WmsuserRole on WUser.Id equals WUserRole.UserId
                //              join WRole in appDBContext.Wmsrole on WUserRole.RoleId equals WRole.Id
                //              where WUser.Id == CustomerID).FirstOrDefault();


                return "sdsffsf";
            }
            return null;
        }

        public string SaveImage(string ImgStr, string ImgName)
        {
            try
            {

                var path = Path.Combine(_hostingEnvironment.ContentRootPath, "Files/productcategory");

                //Check if directory exist
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path); //Create directory if it doesn't exist
                }

                //set the image path
                string imgPath = Path.Combine(path, ImgName);


                if (File.Exists(imgPath))
                {
                    File.Delete(imgPath);
                }
                var base64string = ImgStr.Split(',');
                byte[] imageBytes = Convert.FromBase64String(base64string[1]);

                File.WriteAllBytes(imgPath, imageBytes);

                return imgPath;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [Obsolete]
        public List<MainCategory> spGetProductCategory()
        {
            List<SpGetProductCategory> lst = new List<SpGetProductCategory>();

            try
            {
                List<MainCategory> _main = new List<MainCategory>();
                MainCategory main;
                string sqlQuery = "EXEC [dbo].[SpGetProductCategory]";
                lst =  appDBContext.SpGetProductCategory.FromSqlRaw(sqlQuery).ToList();


                foreach (var ll in lst)
                {
                    main = new MainCategory()
                    {
                        MainCtgyId = ll.MainCtgyId,
                        MainCtgyName = ll.MainCtgyName,
                        MainCtgyDcpn = ll.MainCtgyDcpn,
                        MainCtgyCustId = (int)ll.MainCtgyCustId,
                        MainCtgyParent = (int)ll.MainCtgyParent,
                        MainCtgyPath = ll.MainCtgyPath,
                        _Category = new List<_Category>()
                        {
                            new _Category()
                            {
                                _CtgyId = ll._CtgyId,
                                _CtgyName = ll._CtgyName,
                                _CtgyDcpn = ll._CtgyDcpn,
                                _CtgyCustId = ll._CtgyCustId,
                                _CtgyParent = ll._CtgyParent,
                                _CtgyPath = ll._CtgyPath,
                                __Category = new List<__Category>()
                                {
                                    new __Category()
                                    {
                                        __CtgyId = ll.__CtgyId,
                                        __CtgyName = ll.__CtgyName,
                                        __CtgyDcpn = ll.__CtgyDcpn,
                                        __CtgyCustId = ll.__CtgyCustId,
                                        __CtgyParent = ll.__CtgyParent,
                                        __CtgyPath = ll.__CtgyPath,
                                        ___Category = new List<___Category>()
                                        {
                                            new ___Category()
                                            {
                                                ___CtgyId = ll.___CtgyId,
                                                ___CtgyName = ll.___CtgyName,
                                                ___CtgyDcpn = ll.___CtgyDcpn,
                                                ___CtgyCustId = ll.___CtgyCustId,
                                                ___CtgyParent = ll.___CtgyParent,
                                                ___CtgyPath = ll.___CtgyPath,
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };

                    _main.Add(main);
                }

                _main =  _main.GroupBy(x => x.MainCtgyId)
                             .Select(y => new MainCategory
                             {
                                 MainCtgyId = y.Key,
                                 MainCtgyName = y.Select(x => x.MainCtgyName).FirstOrDefault(),
                                 MainCtgyDcpn = y.Select(x => x.MainCtgyDcpn).FirstOrDefault(),
                                 MainCtgyCustId = y.Select(x => x.MainCtgyCustId).FirstOrDefault(),
                                 MainCtgyParent = y.Select(x => x.MainCtgyParent).FirstOrDefault(),
                                 MainCtgyPath = y.Select(x => x.MainCtgyPath).FirstOrDefault(),
                                 _Category = y.SelectMany(x => x._Category)
                                              .Select(a => new { a._CtgyCustId, a._CtgyDcpn, a._CtgyId, a._CtgyName, a._CtgyParent, a._CtgyPath, a.__Category })
                                              .GroupBy(b => b._CtgyId)
                                              .Select(z => new _Category
                                              {
                                                  _CtgyId = z.Select(x => x._CtgyId).FirstOrDefault(),
                                                  _CtgyName = z.Select(x => x._CtgyName).FirstOrDefault(),
                                                  _CtgyDcpn = z.Select(x => x._CtgyDcpn).FirstOrDefault(),
                                                  _CtgyCustId = z.Select(x => x._CtgyCustId).FirstOrDefault(),
                                                  _CtgyParent = z.Select(x => x._CtgyParent).FirstOrDefault(),
                                                  _CtgyPath = z.Select(x => x._CtgyPath).FirstOrDefault(),
                                                  __Category = z.SelectMany(x => x.__Category)
                                                              .Select(a => new { a.__CtgyCustId, a.__CtgyDcpn, a.__CtgyId, a.__CtgyName, a.__CtgyParent, a.__CtgyPath, a.___Category })
                                                              .GroupBy(b => b.__CtgyId)
                                                              .Select(c => new __Category
                                                              {
                                                                  __CtgyId = c.Select(x => x.__CtgyId).FirstOrDefault(),
                                                                  __CtgyName = c.Select(x => x.__CtgyName).FirstOrDefault(),
                                                                  __CtgyDcpn = c.Select(x => x.__CtgyDcpn).FirstOrDefault(),
                                                                  __CtgyCustId = c.Select(x => x.__CtgyCustId).FirstOrDefault(),
                                                                  __CtgyParent = c.Select(x => x.__CtgyParent).FirstOrDefault(),
                                                                  __CtgyPath = c.Select(x => x.__CtgyPath).FirstOrDefault(),
                                                                  ___Category = c.SelectMany(x => x.___Category)
                                                                                .Select(a => new { a.___CtgyCustId, a.___CtgyDcpn, a.___CtgyId, a.___CtgyName, a.___CtgyParent, a.___CtgyPath })
                                                                                .GroupBy(b => b.___CtgyId)
                                                                                .Select(v => new ___Category
                                                                                {
                                                                                    ___CtgyId = v.Select(x => x.___CtgyId).FirstOrDefault(),
                                                                                    ___CtgyName = v.Select(x => x.___CtgyName).FirstOrDefault(),
                                                                                    ___CtgyDcpn = v.Select(x => x.___CtgyDcpn).FirstOrDefault(),
                                                                                    ___CtgyCustId = v.Select(x => x.___CtgyCustId).FirstOrDefault(),
                                                                                    ___CtgyParent = v.Select(x => x.___CtgyParent).FirstOrDefault(),
                                                                                    ___CtgyPath = v.Select(x => x.___CtgyPath).FirstOrDefault(),
                                                                                }).ToList()
                                                              }).ToList()
                                              }).ToList()
                             }).ToList();

                return  _main;

            }
            catch (Exception )
            {
                return null;
            }
        }

        public bool DeleteCategory(List<ListCheck> listChecks)
        {
            try
            {
                if (listChecks.Count > 0)
                {
                    foreach (var i in listChecks)
                    {
                        var result = appDBContext.ProductCatagory.Where(x => x.ProductCatagoryId == i.CategoryID).First();
                        if (result != null)
                        {
                            appDBContext.ProductCatagory.Remove(result);
                            appDBContext.SaveChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
                else
                {
                    return false;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
