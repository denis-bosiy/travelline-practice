using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todo_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IToDoRepository _repository;

        public TodoController(IToDoRepository todoRepository)
        {
            _repository = todoRepository;
        }

        // GET: api/<TodoController>
        [HttpGet]
        public List<ToDoDto> Get()
        {
            return _repository.GetAll();
        }

        // POST api/<TodoController>
        [HttpPost]
        public int Post([FromBody] ToDoDto toDoDto)
        {
            return _repository.Create(toDoDto);
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ToDoDto toDoDto)
        {
            _repository.Update(id, toDoDto);
        }
    }
}
