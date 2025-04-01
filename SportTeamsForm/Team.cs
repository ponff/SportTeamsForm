using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SportTeamsProg
{
    class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int PlayerCount { get; set; }
        public bool IsProfessional { get; set; }

        public Team()
        {

        }

        public Team (string teamName, int playerCount, bool isProfessional)
        {
            this.TeamName = teamName;
            this.PlayerCount = playerCount;
            this.IsProfessional = isProfessional;
        }

        public Team(int id, string teamName)
        {
            this.Id = id;
            this.TeamName = teamName;
        }
        public Team(int id, bool isProfessional)
        {
            this.Id = id;

            this.IsProfessional = isProfessional;
        }
        public Team(int id, int playerCount)
        {
            this.Id = id;

            this.PlayerCount = playerCount;
        }


        public Team(int id, string teamName, int playerCount, bool isProfessional)
        {
            this.Id = id;
            this.TeamName = teamName;
            this.PlayerCount = playerCount;
            this.IsProfessional = isProfessional;
        }
    }

}
