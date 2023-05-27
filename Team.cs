using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCsProgram
{
    class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public double AverageAge
        {
            get
            {
                if (Players.Count == 0)
                    return 0;
                int totalAge = 0;
                foreach (var player in Players)
                {
                    totalAge += player.Age;
                }

                return (double)totalAge / Players.Count;
            }
        }

    }
}
