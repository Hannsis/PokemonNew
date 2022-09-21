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

            int SquirtleHP = 44;
            int BulbaHP = 44;
            int CharHP = 44;
            
            Random attack = new Random();
            int damage = attack.Next(1, 25);

            SpelIntro();

            string pokemonChoice = Console.ReadLine();

            while (PlayGame)
            {

                if (pokemonChoice == "1")
                {
                    while (PlayGame)
                    {
                        Console.Clear();
                        Console.WriteLine($"You have chosen {Pokemon.Bulbasaur}");
                        Console.WriteLine($"A wild {Pokemon.Charmander} appeared! ");
                        Console.WriteLine("Pick a move, or run away");

                        while (true) 
                        {

                            BulbasaursMoves();

                            int attackList = 0;
                            string input = Console.ReadLine();
                            int.TryParse(input, out attackList);

                            switch (attackList)
                            {
                                case 1:

                                    int leechseed = BulbaHP / 8;
                                    BulbaHP += leechseed;
                                    CharHP -= leechseed;

                                    Console.WriteLine($"{Pokemon.Bulbasaur} used {BulbasaursAttacks.Leech_Seed}! " +
                                        $"\n{Pokemon.Charmander}s looses {leechseed}HP and {Pokemon.Bulbasaur} gains {leechseed}HP." +
                                        $"\n{Pokemon.Bulbasaur} has {BulbaHP}HP left!" +
                                        $"\n{Pokemon.Charmander} has {CharHP}HP left");

                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine($"{Pokemon.Bulbasaur} used {BulbasaursAttacks.Growl}! {Pokemon.Charmander}s attack went down.");
                                    break;
                                case 3:
                                    CharHP -= damage;
                                    Console.WriteLine($"{Pokemon.Bulbasaur} used {BulbasaursAttacks.Vine_Whip}! {Pokemon.Charmander} lost {damage}HP." +
                                         $"\n{Pokemon.Charmander} has {CharHP}HP left");                                                          
                                   
                                    break;
                                case 4:
                                    Console.WriteLine($"{Pokemon.Bulbasaur} used {BulbasaursAttacks.Tackle}! {Pokemon.Charmander}s defences went down.");
                                    break;
                                default:
                                    break;

                                    
                            }

                            /*leech seed
                             growl
                            vinw ehip
                            tackle*/
                          
                        }
                    }
                }
                else if (pokemonChoice == "2")
                {
                    while (PlayGame)
                    {
                        Console.Clear();
                        Console.WriteLine($"You have chosen {Pokemon.Charmander}");//char
                        Console.WriteLine($"A wild {Pokemon.Squirtle} appeared! ");//squirtle

                        string attackList = "";
                        Console.WriteLine("Pick a move, or run away");

                        while (attackList != "5")
                        {


                            Console.WriteLine();

                            Console.WriteLine("Which move should you use?");
                            Console.WriteLine($"1. {CharmandersAttacks.Ember}");
                            Console.WriteLine($"2. {CharmandersAttacks.Growl}");
                            Console.WriteLine($"3. {CharmandersAttacks.Leer}");
                            Console.WriteLine($"4. {CharmandersAttacks.Scratch}");
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
                        Console.WriteLine($"You have chosen {Pokemon.Squirtle}");//squirtle
                        Console.WriteLine($"A wild {Pokemon.Bulbasaur} appeared! ");//bulba

                        string attackList = "";
                        Console.WriteLine("Pick a move, or run away");


                        while (attackList != "5")
                        {
                          
                            Console.WriteLine();

                            Console.WriteLine("Which move should you use?");
                            Console.WriteLine($"1. {SquirtlesAttacks.Bubble}");
                            Console.WriteLine($"2. {SquirtlesAttacks.Tackle}");
                            Console.WriteLine($"3. {SquirtlesAttacks.Tail_Whip}");
                            Console.WriteLine($"4. {SquirtlesAttacks.Watergun}");
                            Console.WriteLine("5. RUN (Avsluta programmet)");

                            attackList = Console.ReadLine();

                            switch (attackList)
                            {
                                case "1":
                                    Console.WriteLine($"Squirtle used {SquirtlesAttacks.Bubble}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Squirtle used {SquirtlesAttacks.Tackle}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Squirtle used {SquirtlesAttacks.Tail_Whip}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Squirtle used {SquirtlesAttacks.Watergun}");
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
                                int attackstats = 0;

                                Console.WriteLine("yolo");
                                Console.WriteLine($"\r\nThe attack gave {attack} damage");
                                Console.WriteLine($"{Pokemon.Squirtle} took {attack} damage!");
                                //BulbaHP -= attack;

                                Console.WriteLine($" Bulbasaur has {BulbaHP} HP left");
                                if (true)
                                {

                                }
                                else if (true)
                                {

                                }
                                else if (true)
                                { }
                                else
                                {

                                }


                            }
                            else if (attackList == "2")
                            {
                                Console.WriteLine("yolo");
                                Console.WriteLine($"\r\nThe attack gave {attack} damage");
                            }
                            else if (attackList == "3")
                            {
                                Console.WriteLine("yolo");
                                Console.WriteLine($"\r\nThe attack gave {attack} damage");
                            }
                            else if (attackList == "4")
                            {
                                Console.WriteLine("yolo");
                                Console.WriteLine($"\r\nThe attack gave {attack} damage");
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

        static void SpelIntro()
        {
            Console.WriteLine("Welcome to the world of pokémon! ");

            Console.WriteLine
                   ($"Time to pick your pokemon! Which pokemon do you chose? " +

                   $"\n\n1. {Pokemon.Bulbasaur} has 44 HP, is a grass type pokémon, its attacks are: \ntackle \nleech seed \nvine whip \nand growl!" +
                   $"\n\n2. {Pokemon.Charmander} has 44 HP, is a fire type pokémon, its attacks are: \ngrowl \nscratch \nember \nand leer!" +
                   $"\n\n3. {Pokemon.Squirtle} is a water type pokémon, it has 44 HP! And it's attacks are: \nTackle, \nwatergun, \ntailwhip \nand bubble!");
        }
        static void BulbasaursMoves() 
        {
     

            Console.WriteLine("Which move should you use?");
            Console.WriteLine($"1. {BulbasaursAttacks.Leech_Seed}");
            Console.WriteLine($"2. {BulbasaursAttacks.Growl}");
            Console.WriteLine($"3. {BulbasaursAttacks.Vine_Whip}");
            Console.WriteLine($"4. {BulbasaursAttacks.Tackle}");
            Console.WriteLine("5. RUN (Avsluta programmet)");
        }
    }


    enum Pokemon
    {
        Bulbasaur,
        Charmander,
        Squirtle,
    }

    enum BulbasaursAttacks
    {
        Growl,
        Tackle,
        Vine_Whip,
        Leech_Seed
    }

    enum CharmandersAttacks
    {
        Growl,
        Scratch,
        Leer,
        Ember

    }

    enum SquirtlesAttacks
    {
        Tackle,
        Bubble,
        Watergun,
        Tail_Whip
    }


}

