using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using todo_web_api.Entities;

namespace WebApi.DbInfrastructure
{
    public class ToDoEntityConfiguration : IEntityTypeConfiguration<ToDoEntity>
    {
        public void Configure(EntityTypeBuilder<ToDoEntity> builder)
        {
            builder.ToTable("Tasks")
                .HasKey(item => item.Id);

            builder.Property(item => item.Id)
                .HasColumnName("TaskId");
        }
    }
}