using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_web_api
{
    public class TodoRepository
    {
        private static List<ToDo> Database = new List<ToDo>();
        
        private class ToDo
        {
            public int Id { get; }
            public string Name { get; set; }

            public bool Done { get; set; }

            public DateTime CreationDate { get;  }

            public ToDo(int id, string name, bool done)
            {
                Id = id;
                Name = name;
                Done = done;
                CreationDate = DateTime.Now;
            }
        }

        public int GetId()
        {
            if (Database.Count > 0)
            {
                return Database.Max(x => x.Id) + 1;
            } else
            {
                return 1;
            }
        }
        public List<ToDoDto> GetAll()
        {
            return Database.ConvertAll(todo => new ToDoDto
            {
                Id = todo.Id,
                Name = todo.Name,
                Done = todo.Done
            });
        }

        public int Create(ToDoDto toDoDto)
        {
            int id = GetId();
            ToDo todo = new ToDo(id, toDoDto.Name, toDoDto.Done);
            Database.Add(todo);
            return id;
        }

        public void Update(ToDoDto toDoDto)
        {
            ToDo finded = Database.Find(x => x.Id == toDoDto.Id);
            if (finded == null)
            {
                return;
            }
            finded.Done = toDoDto.Done;
            finded.Name = toDoDto.Name;
        }
    }
}
