using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using TodoApp.DTO.TodoDtos;
using TodoApp.UI.Helpers;

namespace TodoApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            return View();
            
        }

        public async Task<IActionResult> GetAll()
        {
            var values = await _client.GetFromJsonAsync<List<ResultTodoDto>>("todos");
            return Json(values);
        }

        public async Task <IActionResult> Delete(int id)
        {
             var value = await _client.DeleteAsync("todos/"+id);
            return Json(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTodoDto createTodoDto)
        {
            var value = await _client.PostAsJsonAsync("todos", createTodoDto);
            return Json(new { success = true });
        }
    }
}
