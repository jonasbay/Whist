using System;
using System.Collections.Generic;
using Whist.Models;

namespace Whist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Whist game players!");
            
            using(var context = new MyDBContext())
            {
                Console.WriteLine("Keep track of your games by using the WhistApp!");
                Console.WriteLine("Usage:");
                Console.WriteLine("Create: r(Round), g(Game), p(Players), or s(Attach result)");
                Console.WriteLine("Lists: XXX");

                while(true)
                {
                    Console.WriteLine("Type command");
                    string line = Console.ReadLine();

                    switch(line)
                    {
                        case "p":
                            Players players = InputPlayer();
                            context.Players.Add(players);
                            context.SaveChanges();
                            break;
                        case "g":
                            Games games = InputGames();
                            context.Games.Add(games);
                            context.SaveChanges();
                            break;
                            /*case "r":
                                GameRounds gameRounds = InputGameRounds();
                                context.GameRounds.Add(gameRounds);
                                context.SaveChanges();
                                break;*/
                    }


                }

                




            }
        }

        private static Players InputPlayer()
        {
            Console.Write("Player first name: ");
            string firstname = Console.ReadLine();

            Console.Write("Player last name: ");
            string lastname = Console.ReadLine();

            return new Players()
            {
                FirstName = firstname,
                LastName = lastname
            };
        }

        private static Games InputGames()
        {
            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Is the game started (yes/no): ");
            string yesNo = Console.ReadLine();
            bool started = YesNo(yesNo);

            Console.Write("Is the game ended (yes/no): ");
            string E_yesNo = Console.ReadLine();
            bool ended = YesNo(E_yesNo);

            Console.Write("Is the game updated (yes/no): ");
            string U_yesNo = Console.ReadLine();
            bool updated = YesNo(U_yesNo);

            Games games = new Games()
            {
                Description = description,
                Started = started,
                Ended = ended,
                Updates = updated
            };

            string y_n;
            Console.WriteLine("How many locations are the game played from?");
            int number = Convert.ToInt32(Console.ReadLine());
            String[] locationArray = new String[number];
            Console.WriteLine("Add all your game locations: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write("Location: ");
                string locationName = Console.ReadLine();
            }

            games.LocationList = new List<Location>();
            
            foreach (var item in locationArray)
            {
                new Location()
                {
                    Name = item,
                    GameId = games.Id
                };
            }

            return games;
        }

        private static bool YesNo(string yesNo)
        {
                if (yesNo == "yes")
                    return true;
                else if (yesNo == "no")
                    return false;
                else
                {
                    Console.WriteLine("Type yes or no!");
                    yesNo = Console.ReadLine();
                    return YesNo(yesNo);
                }
        }

        /*private static GameRounds InputGameRounds()
        {
            Console.Write("Id of game round: ");
            int id = Convert.ToInt32(Console.ReadLine());
        }*/


    }
}
