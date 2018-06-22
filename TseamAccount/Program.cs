using System;
using System.Collections.Generic;
using System.Linq;

namespace TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var PeshosGamesList = GetPeshosGames();
            PrintGames(PeshosGamesList);
        }

        private static void PrintGames(List<string> peshosGamesList)
        {
            foreach (var item in peshosGamesList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static List<string> GetPeshosGames()
        {
            var games = Console.ReadLine();
            var command = Console.ReadLine();
            var ListOfGames = games.Split(' ').ToList();
            
            while (command != "Play!")
            {
                var input = command.Split(' ', '-').ToList();
                var action = input[0];
                var game = input[1];

                switch (action)
                {
                    case "Install":
                        if (ListOfGames.Contains(game))
                        {
                            continue;
                        }
                        else
                        {
                            ListOfGames.Add(game);
                        }
                        break;
                    case "Uninstall":
                        if (ListOfGames.Contains(game))
                        {
                            ListOfGames.Remove(game);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Update":
                        if (ListOfGames.Contains(game))
                        {
                            var temp = game;
                            ListOfGames.Remove(game);
                            ListOfGames.Add(temp);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Expansion":
                        if (ListOfGames.Contains(game))
                        {
                            var position = ListOfGames.IndexOf(game);
                            var expansion = input[2];
                            string temp = game + ":" + expansion;
                            ListOfGames.Insert(position + 1, temp);
                                                       
                        }
                        else
                        {
                            continue;
                        }
                        break;

                }

                command = Console.ReadLine();
            }

            return ListOfGames;
        }
    }
}
