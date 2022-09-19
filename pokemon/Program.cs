using System.Security.Cryptography.X509Certificates;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool PlayGame = true;

            List<string> pokemon = new();
            pokemon.Add("Pikachu"); //0
            pokemon.Add("Bulbasaur");//1
            pokemon.Add("Charmander");//2
            pokemon.Add("Squirtle");//3


            Console.WriteLine("Welcome to the workd of pokémon! ");

            Console.WriteLine
                ($"Time to pick your pokemon! Which pokemon do you chose? " +

                $"\n\n1. {pokemon[0]} has 35HP, is an electric type pokémon, its attacks are: \nQuick attack, \nTail whip, \nthunder shock \nand thunder wave! " +
                $"\n\n2. {pokemon[1]} has 44 HP, is a grass type pokémon, its attacks are: \ntackle \nleech seed \nvine whip \nand growl!" +
                $"\n\n3. {pokemon[2]} has 39 HP, is a fire type pokémon, its attacks are: \ngrown \nscratch \nember \nand leer!" +
                $"\n\n4. {pokemon[3]} is a water type pokémon, it has 44 HP! And it's attacks are: \nTackle, \nwatergun, \ntailwhip \nand bubble!");
            
            
            while (PlayGame)
            {

                Console.Clear();
                Console.WriteLine($"A wild {pokemon[1]} appeared! ");

                string attackChoice = "";

                Console.WriteLine("Pick a move, or run away");

                while (attackChoice != "5")
                {

                    Console.WriteLine();

                    Console.WriteLine("Vilken attack vill du välja?");
                    Console.WriteLine("1. TACKLE");
                    Console.WriteLine("2. BUBBLE");
                    Console.WriteLine("3. WATERGUN");
                    Console.WriteLine("4. TAIL WHIP");
                    Console.WriteLine("5. RUN (Avsluta programmet)");

                    attackChoice = Console.ReadLine();

                    switch (attackChoice)
                    {
                        case "1":
                            Console.WriteLine("Squirtle used TACKLE");
                            break;

                        case "2":
                            Console.WriteLine("Squirtle used BUBBLE");
                            break;

                        case "3":
                            Console.WriteLine("Squirtle used WATERGUN");
                            break;

                        case "4":
                            Console.WriteLine("Squirtle used TAILWHIP");
                            break;

                        case "5":
                            Console.WriteLine("You have run away");
                            break;

                        default:
                            Console.WriteLine("Du valde inte ett giltigt alternativ.");
                            break;

                    }
                }

            }
           
        }

        }
        public string ChosePokemon(string pokemon)
        {
        string pokemonChoice = Console.ReadLine();

        switch (pokemonChoice)

        {
            case "1":
                Console.WriteLine($"You have chosen {pokemon[0]}");

                break;
            case "2":
                Console.WriteLine($"You have chosen {pokemon[1]}");
                break;
            case "3":
                Console.WriteLine($"You have chosen {pokemon[2]}");
                break;
            case "4":
                Console.WriteLine($"You have chosen {pokemon[3]}");

                break;
            default:
                Console.WriteLine("It's dangerous to go alone, please bring a pokémon!");
                break;

           return pokemon;
        }
    }

    
}
  
