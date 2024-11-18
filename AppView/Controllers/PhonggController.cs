using AppData;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace AppView.Controllers
{
    public class PhonggController : Controller
    {
        private readonly HttpClient _httpClient;
        public PhonggController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("https://localhost:7056/api/Phong");
            var jsonData = await response.Content.ReadAsStringAsync();
            var khList = JsonConvert.DeserializeObject<List<Phong>>(jsonData);
            return View(khList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Phong kh)
        {
            var jsonData = JsonConvert.SerializeObject(kh);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:7056/api/Phong", content);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var khEdit = await _httpClient.GetAsync($"https://localhost:7056/api/Phong/{id}");
            var jsonStr = await khEdit.Content.ReadAsStringAsync();
            var kh = JsonConvert.DeserializeObject<Phong>(jsonStr);
            return View(kh);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Phong kh)
        {
            var jsonData = JsonConvert.SerializeObject(kh);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"https://localhost:7056/api/Phong/{kh.MaPhong}", content);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7056/api/Phong/{id}");
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int id)
        {
            var reponse = await _httpClient.GetAsync($"https://localhost:7056/api/Phong/{id}");
            var jsonData = await reponse.Content.ReadAsStringAsync();
            var kh = JsonConvert.DeserializeObject<Phong>(jsonData);
            return View(kh);
        }
    }
}