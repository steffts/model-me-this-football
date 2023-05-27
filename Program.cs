using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Goalkeeper { Name = "Mendy", Age = 31, Number = 16, Height = 194 };
            var player2 = new Defender { Name = "Silva", Age = 38, Number = 6, Height = 183 };
            var player3 = new Midfield { Name = "Havertz", Age = 23, Number = 29, Height = 193 };
            var player4 = new Striker { Name = "Haaland", Age = 22, Number = 9, Height = 196 };

            var coach = new Coach { Name = "Frank", Age = 44 };

            var team1 = new Team
            {
                Coach = coach,
                Players = new List<FootballPlayer> { player1, player2, player3, player4 }
            };

            var referee = new Referee { Name = "John", Age = 35 };

            var assistantReferee1 = new AssistantReferee { Name = "Mike", Age = 32 };
            var assistantReferee2 = new AssistantReferee { Name = "Roger", Age = 30 };

            var game = new Game
            {
                Team1 = team1,
                Team2 = new Team(),
                Referee = referee,
                AssistantReferees = new List<AssistantReferee> { assistantReferee1, assistantReferee2 }
            };

            Console.WriteLine("Game result: ");
            Console.WriteLine("Team 1: " + game.Team1.Coach.Name);
            Console.WriteLine("Players: ");

            foreach (var player in game.Team1.Players)
            {
                Console.WriteLine("- " + player.Name);
            }
            Console.WriteLine("Average age: " + game.Team1.AverageAge);
            Console.WriteLine("Referee: " + game.Referee.Name);
            Console.WriteLine("Assistant referees: ");

            foreach (var assistantReferee in game.AssistantReferees)
            {
                Console.WriteLine("- " + assistantReferee.Name);
            }
            Console.WriteLine("Result: " + game.Reasult);
            Console.WriteLine("Winner: " + (game.Winner != null ? game.Winner.Coach.Name : "N/A"));

            Console.ReadLine();

        }
    }
}
