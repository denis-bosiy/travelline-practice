using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_web_api
{
    public interface IToDoRepository
    {
        public List<ToDoDto> GetAll();

        public int Create(ToDoDto toDoDto);

        public void Update(int id, ToDoDto toDoDto);
    }
}
