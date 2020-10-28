using System;
using Npgsql;

namespace ADOExample
{

    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "host=localhost;db=NorthWind;uid=postgres;pwd=bobbystyrer";
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var cmd = new NpgsqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "select categoryid, categoryname from categories";

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var category = new Category
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                };

                Console.WriteLine(category);

                //Console.WriteLine($"Id={reader.GetInt32(0)}, Name={reader.GetString(1)}");
            }
        }
    }
}
