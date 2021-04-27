using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbInfrastructure;

namespace todo_web_api.Infrastructure
{
    public class ToDoDbContext : DbContext, IUnitOfWork
    {
        public ToDoDbContext( DbContextOptions<ToDoDbContext> options ) : base( options )
        {

        }

        void IUnitOfWork.Commit()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ToDoEntityConfiguration());
        }

    }
}
