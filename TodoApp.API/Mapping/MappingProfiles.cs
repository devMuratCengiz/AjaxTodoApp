using AutoMapper;
using TodoApp.DTO.TodoDtos;
using TodoApp.Entity.Entities;

namespace TodoApp.API.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateTodoDto, Todo>().ReverseMap();
            CreateMap<ResultTodoDto,Todo>().ReverseMap();
        }
    }
}
