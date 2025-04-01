using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace SportTeamsProg
{
    class TeamRepository
    {
        private readonly MySqlConnection _connection;

        public TeamRepository(MySqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Team team)
        {
            string insertQuery = "INSERT INTO Teams (TeamName, PlayerCount, IsProfessional) VALUES (@TeamName, @PlayerCount, @IsProfessional)";
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@TeamName", team.TeamName);
                cmd.Parameters.AddWithValue("@PlayerCount", team.PlayerCount);
                cmd.Parameters.AddWithValue("@IsProfessional", team.IsProfessional);
                int rowsInserted = cmd.ExecuteNonQuery();
                return rowsInserted > 0;
            }
        }

        public bool Delete(int id)
        {
            string deleteQuery = "DELETE FROM Teams WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                int rowsDeleted = cmd.ExecuteNonQuery();
                return rowsDeleted > 0;
            }
        }

        public bool UpdateAllPos(Team team)
        {
            string updateQuery = "UPDATE Teams SET TeamName = @TeamName, PlayerCount = @PlayerCount, IsProfessional = @IsProfessional WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(updateQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@TeamName", team.TeamName);
                cmd.Parameters.AddWithValue("@PlayerCount", team.PlayerCount);
                cmd.Parameters.AddWithValue("@IsProfessional", team.IsProfessional);
                cmd.Parameters.AddWithValue("@Id", team.Id); // Добавлено для указания Id
                int rowsUpdated = cmd.ExecuteNonQuery();
                return rowsUpdated > 0;
            }
        }

        public bool UpdateTeamName(Team team)
        {
            string updateQuery = "UPDATE Teams SET TeamName = @TeamName WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(updateQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@TeamName", team.TeamName);
                cmd.Parameters.AddWithValue("@Id", team.Id); // Добавлено для указания Id
                int rowsUpdated = cmd.ExecuteNonQuery();
                return rowsUpdated > 0;
            }
        }

        public bool UpdatePlayerCount(Team team)
        {
            string updateQuery = "UPDATE Teams SET PlayerCount = @PlayerCount WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(updateQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@PlayerCount", team.PlayerCount);
                cmd.Parameters.AddWithValue("@Id", team.Id); // Добавлено для указания Id
                int rowsUpdated = cmd.ExecuteNonQuery();
                return rowsUpdated > 0;
            }
        }

        public bool UpdateIsProfessional(Team team)
        {
            string updateQuery = "UPDATE Teams SET IsProfessional = @IsProfessional WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(updateQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@IsProfessional", team.IsProfessional);
                cmd.Parameters.AddWithValue("@Id", team.Id); // Добавлено для указания Id
                int rowsUpdated = cmd.ExecuteNonQuery();
                return rowsUpdated > 0;
            }
        }

        public Team? Get(int id)
        {
            string selectQuery = "SELECT Id, TeamName, PlayerCount, IsProfessional FROM Teams WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Team
                        {
                            Id = reader.GetInt32("Id"),
                            TeamName = reader.GetString("TeamName"),
                            PlayerCount = reader.GetInt32("PlayerCount"),
                            IsProfessional = reader.GetBoolean("IsProfessional")
                        };
                    }
                }
            }
            return null;
        }

        public List<Team> GetAll()
        {
            List<Team> teams = new List<Team>();
            string selectQuery = "SELECT Id, TeamName, PlayerCount, IsProfessional FROM Teams";
            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _connection))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    teams.Add(new Team
                    {
                        Id = reader.GetInt32("Id"),
                        TeamName = reader.GetString("TeamName"),
                        PlayerCount = reader.GetInt32("PlayerCount"),
                        IsProfessional = reader.GetBoolean("IsProfessional")
                    });
                }
            }
            return teams;
        }
    }
}