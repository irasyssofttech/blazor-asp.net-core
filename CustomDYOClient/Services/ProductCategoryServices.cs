using CustomDYOClient.Model;
using CustomDYOClient.wwwroot;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomDYOClient.Services
{
    public class ProductCategoryServices : IProductCategoryServices
    {
        private readonly HttpClient httpClient;
        private string WebApiUrl = "";
        protected async Task CallApi()
        {
            var response = await httpClient.GetFromJsonAsync<Settings>("Settings.json");
            WebApiUrl = response.ApiUrl;
        }
        public ProductCategoryServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }

        public async Task<IEnumerable<Wmsuser>> GetAdminUser(string RoleName)
        {
            try
            {
                //var response = await httpClient.GetFromJsonAsync<Settings>("Settings.json");
                return await JsonSerializer.DeserializeAsync<IEnumerable<Wmsuser>>
                (await httpClient.GetStreamAsync("http://localhost:58375/api/ProductCategory/" + RoleName), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
            catch(Exception)
            {
                return null;
            }
        }

        public Task<string> GetCustomerDrop(int CustomerID)
        {
            throw new NotImplementedException();


        }

        public async Task<IEnumerable<ProductCatagory>> GetProductCategory()
        {
            try
            {
                return await JsonSerializer.DeserializeAsync<IEnumerable<ProductCatagory>>
                    (await httpClient.GetStreamAsync("http://localhost:58375/api/ProductCategory/"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
            catch(Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<MainCategory>> GetMainCategory()
        {
            try
            {
                return await JsonSerializer.DeserializeAsync<IEnumerable<MainCategory>>
                (await httpClient.GetStreamAsync("http://localhost:58375/api/ProductCategory/GetMainCategory"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<ProductCatagory> PostCategory(ProductCatagory productcategory)
        {
            try
            {

                var CategoryJson = new StringContent(JsonSerializer.Serialize(productcategory), Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("http://localhost:58375/api/ProductCategory", CategoryJson);

                if (response.IsSuccessStatusCode)
                {

                    return await JsonSerializer.DeserializeAsync<ProductCatagory>(await response.Content.ReadAsStreamAsync(), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                }
                else
                {

                    return new ProductCatagory();
                }
            }
            catch (Exception)
            {
                return new ProductCatagory();
            }

        }

        public async Task<ProductCatagory> PutCategory(ProductCatagory productcategory)
        {
            try
            {
                var CategoryJson = new StringContent(JsonSerializer.Serialize(productcategory), Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("http://localhost:58375/api/ProductCategory", CategoryJson);
                if (response.IsSuccessStatusCode)
                {
                    return await JsonSerializer.DeserializeAsync<ProductCatagory>(await response.Content.ReadAsStreamAsync(), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });


                }
                return new ProductCatagory(); 
            }
            catch(Exception)
            {
                return new ProductCatagory();
            }

        }

        public async Task<bool> DeleteCategory(List<ListCheck> _checklist)
        {
            try
            {
                var CategoryJson = new StringContent(JsonSerializer.Serialize(_checklist), Encoding.UTF8, "application/json");
                //var response = await httpClient.DeleteAsync("http://localhost:58375/api/ProductCategory/", CategoryJson);

                var response = httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Delete, "http://localhost:58375/api/ProductCategory/")
                {
                    Content = new StringContent(JsonSerializer.Serialize(_checklist), Encoding.UTF8, "application/json")
                }).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
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
