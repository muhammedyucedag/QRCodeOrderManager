using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.CategoryDtos;

namespace SignalRWebUI.Controllers
{
    public class CategoryController(IHttpClientFactory httpClientFactory) : Controller
    {
        // GET: CategoryController
        public async Task<IActionResult> Index()
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5035/api/categories/GetAllCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<CategoryDto>>(jsonData);
                return View(value);
            }
            return View(new List<CategoryDto>());
        }
        
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        } 
        
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryDto categoryDto)
        {
            categoryDto.Status = true;
            
            var client = httpClientFactory.CreateClient();
            var value = JsonConvert.SerializeObject(categoryDto);
            
            StringContent stringContent = new StringContent(value, Encoding.UTF8, "application/json");
            
            var responseMessage = await client.PostAsync("http://localhost:5035/api/categories", stringContent);
            
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();

        } 

    }
}
