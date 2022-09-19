using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool PlayGame = true;

            List<string> pokemon = new();
            pokemon.Add("Bulbasaur");//1
            pokemon.Add("Charmander");//2
            pokemon.Add("Squirtle");//3


            Console.WriteLine("Welcome to the world of pokémon! ");

            Console.WriteLine
                   ($"Time to pick your pokemon! Which pokemon do you chose? " +

                   $"\n\n1. {pokemon[0]} has 44 HP, is a grass type pokémon, its attacks are: \ntackle \nleech seed \nvine whip \nand growl!" +
                   $"\n\n2. {pokemon[1]} has 39 HP, is a fire type pokémon, its attacks are: \ngrowl \nscratch \nember \nand leer!" +
                   $"\n\n3. {pokemon[2]} is a water type pokémon, it has 44 HP! And it's attacks are: \nTackle, \nwatergun, \ntailwhip \nand bubble!");

            string pokemonChoice = Console.ReadLine();
            while (PlayGame)
            {

                if (pokemonChoice == "1")
                {

                    while (PlayGame)
                    {
                        Console.Clear();
                        Console.WriteLine($"You have chosen {pokemon[0]}");//bulbasaur
                        Console.WriteLine($"A wild {pokemon[1]} appeared! ");//char

                        string attackList = "";
                        Console.WriteLine("Pick a move, or run away");

                        while (attackList != "5")
                        {
                            List<string> BulbasaursAttacks = new();
                            BulbasaursAttacks.Add("growl");
                            BulbasaursAttacks.Add("tackle");
                            BulbasaursAttacks.Add("vine whip");
                            BulbasaursAttacks.Add("leech sead");


                            Console.WriteLine();

                            Console.WriteLine("Which move should you use?");
                            Console.WriteLine($"1. {BulbasaursAttacks[0]}");
                            Console.WriteLine($"2. {BulbasaursAttacks[1]}");
                            Console.WriteLine($"3. {BulbasaursAttacks[2]}");
                            Console.WriteLine($"4. {BulbasaursAttacks[3]}");
                            Console.WriteLine("5. RUN (Avsluta programmet)");

                            attackList = Console.ReadLine();
                            Console.WriteLine($"You used {attackList}");
                        }
                    }
                }
                else if (pokemonChoice == "2")
                {

                    while (PlayGame)
                    {
                        Console.Clear();
                        Console.WriteLine($"You have chosen {pokemon[1]}");//char
                        Console.WriteLine($"A wild {pokemon[2]} appeared! ");//squirtle

                        string attackList = "";
                        Console.WriteLine("Pick a move, or run away");

                        while (attackList != "5")
                        {
                            List<string> CharmandersAttacks = new();
                            CharmandersAttacks.Add("growl");
                            CharmandersAttacks.Add("scratch");
                            CharmandersAttacks.Add("leer");
                            CharmandersAttacks.Add("ember");

                            Console.WriteLine();

                            Console.WriteLine("Which move should you use?");
                            Console.WriteLine($"1. {CharmandersAttacks[0]}");
                            Console.WriteLine($"2. {CharmandersAttacks[1]}");
                            Console.WriteLine($"3. {CharmandersAttacks[2]}");
                            Console.WriteLine($"4. {CharmandersAttacks[3]}");
                            Console.WriteLine("5. RUN (Avsluta programmet)");

                            attackList = Console.ReadLine();
                            Console.WriteLine($"You used {attackList}");
                        }
                    }
                }

                else if (pokemonChoice == "3")
                {

                    while (PlayGame)
                    {
                        Console.Clear();
                        Console.WriteLine($"You have chosen {pokemon[2]}");//squirtle
                        Console.WriteLine($"A wild {pokemon[0]} appeared! ");//bulba

                        string attackList = "";
                        Console.WriteLine("Pick a move, or run away");
                       
                        Random attack = new Random();
                        List<int> attackStats = new();
                        attackStats.Add(attack.Next(1, 25));//normal
                        attackStats.Add(attack.Next(1, 50));//crit chance
                       
                       

                        while (attackList != "5")
                        {
                            List<string> SquirtlesAttacks = new();
                            SquirtlesAttacks.Add("TACKLE");
                            SquirtlesAttacks.Add("BUBBLE");
                            SquirtlesAttacks.Add("WATERGUN");
                            SquirtlesAttacks.Add("TAIL WHIP");

                            Console.WriteLine();

                            Console.WriteLine("Which move should you use?");
                            Console.WriteLine($"1. {SquirtlesAttacks[0]}");
                            Console.WriteLine($"2. {SquirtlesAttacks[1]}");
                            Console.WriteLine($"3. {SquirtlesAttacks[2]}");
                            Console.WriteLine($"4. {SquirtlesAttacks[3]}");
                            Console.WriteLine("5. RUN (Avsluta programmet)");

                            attackList = Console.ReadLine();

                            switch (attackList)
                            {
                                case "1":
                                    Console.WriteLine($"Squirtle used {SquirtlesAttacks[0]}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Squirtle used {SquirtlesAttacks[1]}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Squirtle used {SquirtlesAttacks[2]}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Squirtle used {SquirtlesAttacks[3]}");
                                    break;
                                case "5":
                                    Console.WriteLine("You have run away");
                                    break;
                                default:
                                    Console.WriteLine("Du valde inte ett giltigt alternativ.");
                                    break;


                            }
                            if (attackList == "1")
                            {
                                Console.WriteLine("yolo");
                                Console.WriteLine($"\r\nThe attack gave {attackStats[1]} damage");
                            }
                            else if (attackList == "2")
                            {
                                Console.WriteLine("yolo");
                                Console.WriteLine($"\r\nThe attack gave {attackStats[1]} damage");
                            }
                            else if (attackList == "3")
                            {
                                Console.WriteLine("yolo");
                                Console.WriteLine($"\r\nThe attack gave {attackStats[1]} damage");
                            }
                            else if (attackList == "4")
                            {
                                Console.WriteLine("yolo");
                                Console.WriteLine($"\r\nThe attack gave {attackStats[1]} damage");
                            }
                            else
                                break;


                        }
                    }

                }
                else
                    Console.WriteLine("It's dangerous to go alone, please bring a pokémon!");
                break;


            }




        }
    }
}

