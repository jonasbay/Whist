using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Whist.Models;

namespace Whist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Whist game players!");

            using (var context = new MyDBContext())
            {
                Console.WriteLine("Keep track of your games by using the WhistApp!");
                Console.WriteLine("Usage:");
                Console.WriteLine("If this is your first time using the WhistApp, please follow these steps:");
                Console.WriteLine("Step 1: Add Players (type p)");
                Console.WriteLine("Step 2: Add Game (type g)");
                Console.WriteLine("Step 3: Connect Players to Game (type c)");
                Console.WriteLine("Step 4: Add Game Rounds (type r)");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("See lists of already played games:");
                Console.WriteLine("Option 1: See list of Games (type gl)");
                Console.WriteLine("Option 2: See list of Games with players (type gp)");
                Console.WriteLine("Option 3: See list of Games round players and points (type gr)");

                while (true)
                {
                    Console.WriteLine("Type command");
                    string line = Console.ReadLine();

                    switch (line)
                    {
                        case "p":
                            Players players = InputPlayer();
                            context.Players.Add(players);
                            context.SaveChanges();
                            break;
                        case "g":
                            if (context.Players.Count() < 4)
                            {
                                Console.WriteLine("No enough players!");
                                break;
                            }
                            else
                            {
                                Games games = InputGames(context);
                            }
                            break;
                        case "r":
                            if (context.Games.Count() == 0)
                            {
                                Console.WriteLine("No games exist!");
                                break;
                            }
                            else
                            {
                                GameRounds gameRounds = InputGameRounds(context);
                                context.GameRounds.Add(gameRounds);
                                context.SaveChanges();
                            }
                            break;
                        case "c":
                            if (context.Games.Count() == 0)
                            {
                                Console.WriteLine("No games exist!");
                                break;
                            }
                            else if (context.Players.Count() == 0)
                            {
                                Console.WriteLine("No players exist!");
                                break;
                            }
                            else
                            {
                                GamePlayers gamePlayers = InputGamePlayers(context);
                                context.GamePlayers.Add(gamePlayers);
                                context.SaveChanges();
                            }
                            break;
                        case "gp":
                            ListGamePlayers(context);
                            break;
                        case "gl":
                            ListGames(context);
                            break;
                        case "gr":
                            ListGameRoundPlayers(context);
                            break;

                            //Mangler lister
                    }
                }
            }
        }


        //Show list functions:

       private static void ListGamePlayers(MyDBContext context)
        {
            var gamesPlayerView = context.Games
                .Include(gamesPlayerView => gamesPlayerView.gamePlayersListForGames)
                    .ThenInclude(s => s.Player)
                .ToList();

            foreach (var s in gamesPlayerView)
            {
                Console.WriteLine($"Game Id: {s.Id}, Number of players: {s.gamePlayersListForGames.Count()}");
                foreach (var gamePlayer in s.gamePlayersListForGames)
                {
                    Console.WriteLine($"{gamePlayer.Player.FirstName} {gamePlayer.Player.LastName}");
                }
            }
        }

        private static void ListGameRoundPlayers(MyDBContext context)
        {
            var gamesRoundPlayerView = context.GameRounds
                .Include(gamesRoundPlayerView => gamesRoundPlayerView.GameRoundPlayersList)
                .Include(gamesRoundPlayerView => gamesRoundPlayerView.Games)
                .ToList();
            int i = 0;
            foreach (var s in gamesRoundPlayerView)
            {
                Console.WriteLine($"Game Id: {s.GameId}, Number of players: {s.GameRoundPlayersList.Count()}, Game round number: {s.RoundNum}");
                foreach (var gameRoundPlayer in s.GameRoundPlayersList)
                {
                    Console.WriteLine($"Player {i+1}'s points: {gameRoundPlayer.Points}");
                }
            }
        }


        private static void ListGames(MyDBContext context)
        {
            Console.WriteLine("What game id would you like to see information about?");
            int id = Convert.ToInt32(Console.ReadLine());

            var games = context.Games.Where(p => p.Id == id)
                .Select(p => new{p.Id, p.Description, p.Started, p.Ended, p.Updates}).ToList();
            foreach (var s in games)
            {
                Console.WriteLine(s);
            }
        }


        //Input functions:

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

        private static Games InputGames(MyDBContext context)
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

            //Add locations
            Console.WriteLine("How many locations are the game played from?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add all your game locations: ");

            games.LocationList = new List<Location>();
            for (int i = 0; i < number; i++)
            {
                Console.Write($"Location {i+1}: ");
                string locationName = Console.ReadLine();
                Location location = new Location()
                {
                    Name = locationName,
                    Games = games,
                };
                context.Location.Add(location);
            }

            //Add GamePlayer
            Console.WriteLine("Add all your game players: ");
            games.gamePlayersListForGames = new List<GamePlayers>();
            for (int i = 0; i < 4; i++)
            {
                Players players = findPlayers(context);
                Console.Write($"Points for player {i+1}: ");
                int points = Convert.ToInt32(Console.ReadLine());
                GamePlayers gamePlayers = new GamePlayers()
                {
                    Player = players,
                    Games = games,
                    Points = points
                };
                context.GamePlayers.Add(gamePlayers);
            }
            return games;
        }

        private static GameRounds InputGameRounds(MyDBContext context)
        {
            GameRounds gameRounds;

            Games games = findGame(context);

            Console.Write("What round number are you at?: ");
            int roundNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("What type of round are you playing (sole/normal): ");
            string round = Console.ReadLine();
            
            Console.Write("Is the round started (yes/no): ");
            string yesNo = Console.ReadLine();
            bool started = YesNo(yesNo);

            Console.Write("Is the round ended (yes/no): ");
            string E_yesNo = Console.ReadLine();
            bool ended = YesNo(E_yesNo);


            if (round == "sole")
            {
            
                //Add Type: SoleRound
                Console.Write("What solo type is this?: ");
                string soloType = Console.ReadLine();
                SoleRound soleRound = new SoleRound() { SoloType = soloType };
                context.SoleRound.Add(soleRound);
                gameRounds = new GameRounds()
                {
                    Types = soleRound,
                    RoundNum = roundNum,
                    Started = started,
                    Ended = ended,
                    Games = games,
                };
                //Add SoleRoundWinner
                Console.WriteLine("How many sole round winners are there?");
                int number = Convert.ToInt32(Console.ReadLine());

                gameRounds.SoleRoundWinnerList = new List<SoleRoundWinner>();
                for (int i = 0; i < number; i++)
                {
                    Console.Write($"What is the trick for winner {i + 1}?: ");
                    int trick = Convert.ToInt32(Console.ReadLine());
                    SoleRoundWinner soleRoundWinner = new SoleRoundWinner()
                    {
                        GameRound = gameRounds,
                        Tricks = trick
                    };
                    context.SoleRoundWinner.Add(soleRoundWinner);
                }
            }
            else
            {
                //Add Type: NormalRound
                Console.Write("What is the trick?: ");
                int trick = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the bid attachment?:");
                int bidAttachment = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the bid tricks?:");
                int bidTricks = Convert.ToInt32(Console.ReadLine());

                NormalRound normalRound = new NormalRound()
                {
                    Tricks = trick,
                    BidAttachment = bidAttachment,
                    BitTricks = bidTricks
                };
                context.NormalRound.Add(normalRound);

                gameRounds = new GameRounds()
                {
                    Types = normalRound,
                    RoundNum = roundNum,
                    Started = started,
                    Ended = ended,
                    Games = games,
                };
            }
            //Add GameRoundPlayers
            Console.WriteLine("Add all your game round players: ");            
            gameRounds.GameRoundPlayersList = new List<GameRoundPlayers>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Player {i + 1}'s bye: ");
                int bye = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Player {i + 1}'s points: ");
                int points = Convert.ToInt32(Console.ReadLine());
                GameRoundPlayers gameRoundPlayers = new GameRoundPlayers()
                {
                    Bye = bye,
                    Points = points,
                    GameRounds = gameRounds
                };
                context.GameRoundPlayers.Add(gameRoundPlayers);
            }

            return gameRounds;
        }

        //Add GamePlayers to a game:
        private static GamePlayers InputGamePlayers(MyDBContext context)
        {

            Games games = findGame(context);

            Players players = findPlayers(context);

            Console.Write("Points for player: ");
            int point = Convert.ToInt32(Console.ReadLine());

            return new GamePlayers
            {
                Points = point,
                Games = games,
                Player = players
            };

        }


        //Hjælpefunktioner
        private static Games findGame(MyDBContext context)
        {
            Console.Write("Game id: ");
            int gameId = Convert.ToInt32(Console.ReadLine());

            return context.Games.Where(g => g.Id == gameId).Single();
        }
        private static Players findPlayers(MyDBContext context)
        {
            Console.Write("Player id: ");
            int playerId = Convert.ToInt32(Console.ReadLine());

            return context.Players.Where(g => g.Id == playerId).Single();
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

    }
}
