using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Business.Abstract;
using TodoApp.DTO.TodoDtos;
using TodoApp.Entity.Entities;

namespace TodoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController(IGenericService<Todo> _service, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _mapper.Map<List<ResultTodoDto>>(_service.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Create(CreateTodoDto createTodoDto)
        {
            var value = _mapper.Map<Todo>(createTodoDto);
            _service.TCreate(value);
            return Ok("Created");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.TDelete(id);
            return Ok("Deleted");
        }
    }
}
