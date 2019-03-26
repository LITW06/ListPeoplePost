using System.Collections.Generic;
using System.Data.SqlClient;

namespace PeopleList.Data
{
    public class PersonManager
    {
        private string _connectionString;

        public PersonManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Person> GetPeople()
        {
            var connection = new SqlConnection(_connectionString);
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM People";
            List<Person> ppl = new List<Person>();
            connection.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ppl.Add(new Person
                {
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    Age = (int)reader["Age"]
                });
            }

            connection.Close();
            connection.Dispose();
            return ppl;
        }

        public void AddPerson(Person person)
        {
            var conn = new SqlConnection(_connectionString);
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO People (FirstName, LastName, Age) " +
                              "VALUES (@firstName, @lastName, @age)";
            cmd.Parameters.AddWithValue("@firstName", person.FirstName);
            cmd.Parameters.AddWithValue("@lastName", person.LastName);
            cmd.Parameters.AddWithValue("@age", person.Age);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public void AddPeople(IEnumerable<Person> ppl)
        {
            var conn = new SqlConnection(_connectionString);
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO People (FirstName, LastName, Age) " +
                              "VALUES (@firstName, @lastName, @age)";
            conn.Open();
            foreach (var person in ppl)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@firstName", person.FirstName);
                cmd.Parameters.AddWithValue("@lastName", person.LastName);
                cmd.Parameters.AddWithValue("@age", person.Age);
                cmd.ExecuteNonQuery();
            }

            conn.Close();
            conn.Dispose();
        }
    }
}