using PowerUserRegistered.DAL.Entities;
using PowerUserRegistered.DAL.Mapper;
using PowerUserRegistered.DAL.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerUserRegistered.DAL.Repositories
{
     public class CharacterRepository
    {
        private string _ConnectionString;

        public CharacterRepository(ConnectionString connectionString)
        {
            _ConnectionString = connectionString.Value;
        }
        //Utils
        private SqlConnection CreateConnection()
        {
            return new SqlConnection(_ConnectionString);
        }

        //CRUD
        public IEnumerable<CharacterEntity> GetAll()
        {
            using (SqlConnection connection = CreateConnection())
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Personnage";
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CharacterEntity character = CharacterMapper.ConvertToEntity(reader);
                            yield return character;
                        }
                    }
                }
            }
        }
        public CharacterEntity GetOne(int id)
        {
            using (SqlConnection connection = CreateConnection())
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Personnage WHERE Id = @Id";
                    command.Parameters.AddWithValue("Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CharacterMapper.ConvertToEntity(reader);
                        }
                        return null;
                    }
                }
            }
        }
        public int Create(CharacterEntity character)
        {
            using (SqlConnection connection = CreateConnection())
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Personnage(FirstName, LastName, BirthDate)" +
                                          " OUTPUT inserted.Id" +
                                          " VALUES (@FirstName, @LastName, @BirthDate)";

                    command.Parameters.AddWithValue("FirstName", character.FirstName);
                    command.Parameters.AddWithValue("LastName", character.LastName);
                    command.Parameters.AddWithValue("BirthDate", character.BirthDate);


                    int fighterId = (int)command.ExecuteScalar();
                    return fighterId;
                }
            }
        }

        public CharacterEntity Delete(int id)
        {
            using (SqlConnection connection = CreateConnection())
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Personnage WHERE Id = @Id";
                    command.Parameters.AddWithValue("Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CharacterMapper.ConvertToEntity(reader);
                        }
                        return null;
                    }
                }
            }
        }

    }
}
