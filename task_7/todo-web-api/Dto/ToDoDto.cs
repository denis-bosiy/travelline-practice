using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_web_api.Entities;

namespace todo_web_api
{
    public class ToDoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }
        public DateTime CreationDate { get; set; }

        public ToDoDto()
        {

        }

        public ToDoDto(ToDoEntity toDoEntity)
        {
            Id = toDoEntity.Id;
            Name = toDoEntity.Name;
            Done = toDoEntity.Done;
            CreationDate = toDoEntity.CreationDate;
        }

        public void CopyTo(ToDoEntity toDoEntity)
        {
            toDoEntity.Name = Name;
            toDoEntity.Done = Done;
        }

    }

}
