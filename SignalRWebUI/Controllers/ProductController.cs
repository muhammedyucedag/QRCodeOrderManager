using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.CategoryDtos;
using SignalRWebUI.Dtos.ProductDtos;

namespace SignalRWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var products = await GetProductListAsync("http://localhost:5035/api/products/GetAllProductWithCategory");
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            var categories = await GetCategoryListAsync("http://localhost:5035/api/categories/GetAllCategory");

            if (categories != null)
            {
                var categorySelectList = categories.Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();

                ViewBag.v = categorySelectList;
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDto productDto)
        {
            productDto.Status = true;

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(productDto);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5035/api/products", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            var categories = await GetCategoryListAsync("http://localhost:5035/api/categories/GetAllCategory");
            if (categories != null)
                ViewBag.v = categories.Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();

            return View(productDto);
        }

        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5035/api/products/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(Guid id)
        {
            var categories = await GetCategoryListAsync("http://localhost:5035/api/categories/GetAllCategory");

            if (categories != null)
                ViewBag.v = categories.Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5035/api/products/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var product = JsonConvert.DeserializeObject<ProductDto>(jsonData);
                return View(product);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductDto productDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(productDto);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage =
                await client.PutAsync("http://localhost:5035/api/products/UpdateProduct/", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View(productDto);
        }

        private async Task<List<ProductDto>?> GetProductListAsync(string url)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(url);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ProductDto>>(jsonData);
            }

            return new List<ProductDto>();
        }

        private async Task<List<CategoryDto>?> GetCategoryListAsync(string url)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(url);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<CategoryDto>>(jsonData);
            }

            return new List<CategoryDto>();
        }
    }
}