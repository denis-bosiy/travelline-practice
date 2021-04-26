using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace todo_web_api
{
    public class TodoRepository
    {
        private static string _connectionString = @"Data Source=DESKTOP-F65ASKG\SQLEXPRESS01;Initial Catalog=ToDoDB;Trusted_Connection=Yes";

        private class ToDo
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public bool Done { get; set; }

            public DateTime CreationDate { get; set; }
        }

        public List<ToDoDto> GetAll()
        {
            List<ToDoDto> todos = new List<ToDoDto>();

            using ( SqlConnection connection = new SqlConnection(_connectionString) )
            {
                connection.Open();
                using ( SqlCommand command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                          [TaskId],
                          [Name],
                          [Done],
                          [CreationDate] 
                         FROM Tasks";
                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            var toDo = new ToDoDto
                            {
                                Id = Convert.ToInt32(reader["TaskId"]),
                                Name = Convert.ToString(reader["Name"]),
                                Done = Convert.ToBoolean(reader["Done"] is DBNull ? false : reader["Done"]),
                                CreationDate = Convert.ToDateTime(reader["CreationDate"])
                            };
                            todos.Add(toDo);
                        }
                    }
                }

            }

            return todos;
        }

        public int Create(ToDoDto toDoDto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"INSERT INTO Tasks ([Name], [CreationDate]) VALUES (@name, @creationDate) SELECT SCOPE_IDENTITY()";

                    command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = toDoDto.Name;
                    command.Parameters.Add("@creationDate", System.Data.SqlDbType.DateTime).Value = DateTime.Now;

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public void Update(ToDoDto toDoDto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"UPDATE [Tasks] SET [Done] = @done WHERE TaskId = @taskId";

                    command.Parameters.Add("@done", System.Data.SqlDbType.Bit).Value = Convert.ToInt32(toDoDto.Done);
                    command.Parameters.Add("@taskId", System.Data.SqlDbType.Int).Value = toDoDto.Id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
