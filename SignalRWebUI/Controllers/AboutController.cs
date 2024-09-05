using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.AboutDtos;

namespace SignalRWebUI.Controllers
{
     public class AboutController(IHttpClientFactory httpClientFactory) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5035/api/abouts/GetAllAbout");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<AboutDto>>(jsonData);
                return View(value);
            }
            return View(new List<AboutDto>());
        }
        
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        } 
        
        [HttpPost]
        public async Task<IActionResult> CreateAbout(AboutDto aboutDto)
        {
            var client = httpClientFactory.CreateClient();
            var value = JsonConvert.SerializeObject(aboutDto);
            
            StringContent stringContent = new StringContent(value, Encoding.UTF8, "application/json");
            
            var responseMessage = await client.PostAsync("http://localhost:5035/api/abouts", stringContent);
            
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> DeleteAbout(Guid id)
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5035/api/abouts/{id}");
            
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        
        [HttpGet]
        public async Task<IActionResult> UpdateAbout(Guid id)
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5035/api/abouts/{id}");
            
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<AboutDto>(jsonData);
                
                return View(values);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(AboutDto aboutDto)
        {
            var client = httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(aboutDto);
            
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            
            var responseMessage = await client.PutAsync("http://localhost:5035/api/abouts/UpdateAbout/", stringContent);
            
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
    
}
