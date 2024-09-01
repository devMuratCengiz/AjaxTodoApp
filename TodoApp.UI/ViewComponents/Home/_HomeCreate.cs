using Microsoft.AspNetCore.Mvc;
using TodoApp.DTO.TodoDtos;

namespace TodoApp.UI.ViewComponents.Home
{
    public class _HomeCreate : ViewComponent
    {
       public async Task <IViewComponentResult>InvokeAsync()
        {
            var model = new CreateTodoDto();
            return View(model);
        }
    }
}