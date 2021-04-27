using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using todo_web_api.Infrastructure;
using todo_web_api.Entities;

namespace todo_web_api
{
    public class ToDoRepository: IToDoRepository
    {
        readonly ToDoDbContext _context;
        readonly IUnitOfWork _unitOfWork;

        public ToDoRepository( ToDoDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public List<ToDoDto> GetAll()
        {
            return _context.Set<ToDoEntity>().ToList().Select(item => new ToDoDto(item)).ToList();
        }

        public int Create(ToDoDto toDoDto)
        {
            ToDoEntity newEntity = new ToDoEntity();
            toDoDto.CopyTo(newEntity);
            _context.Set<ToDoEntity>().Add(newEntity);
            _unitOfWork.Commit();
            return newEntity.Id;
        }

        public void Update(int id, ToDoDto toDoDto)
        {
            ToDoEntity foundEntity = _context.Set<ToDoEntity>().SingleOrDefault(item => item.Id == id);
            toDoDto.CopyTo(foundEntity);
            _unitOfWork.Commit();
        }
    }
}
