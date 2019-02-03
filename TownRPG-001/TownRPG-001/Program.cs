using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownRPG_001.Actors;

namespace TownRPG_001
{
    //list of items required for an RPG
    //opening screen with selections for the town
    /* TOWN IDEAS
     * Print out the options for town(Maybe make a 3x3 viewable area for the player)
     * 1) Show Character Status [x]
       2) Go to Shop
       3) Go to Dungeon
       4) Save Game(Inn)
       5) Exit Game  
       */
    //~~~~TODO LIST~~~
    //1)Character Sheet [x]
    //2)Creature Character Sheet[]
    //3)Level Object []
    //4)Save Function []
    //5)
    //Character has strength, intellect, dexterity, charisma, wisdom 
    //all enemies are extention of the actor class
    //forumlas for the different types of stuff later
    //Each Building is its own object(choose which one to end)
    //In dungeon there are possible options(maybe have 4)
    //1) Keep searching 
    //2) Get into fight 
    //3) Find treasure 
    //4) Leave dungeon 
    class Program
    {
        //create a town with main objects
        //
        static void Main(string[] args)
        {
            //print player stats (user input == 1)
            Player player = new Player();

            string phrase = "hello world";
            Console.WriteLine(player.ActorName.Length + "\n");
            StartGame(player);
        }

        public static void StartGame(Player player) {
            Console.WriteLine("Welcome to Tower Town!\nPress 1 for Character Sheet.\nPress 2 for the Tower & Dungeon!.");
            var input = Console.ReadLine();
            Int32.TryParse(input, out int result);
            switch (result)
            {
                case 1:
                    Console.WriteLine("Print Character:");
                    player.Print();
                    break;
                case 2:
                    Console.WriteLine("Enter the Tower");
                    break;
                default:
                    //recursive loop
                    Console.WriteLine("nothing here");
                    StartGame(player);

                    //ends
                    //send into a function for while loop
                    break;
            }

        }
    }
}
