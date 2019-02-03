using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerRPG
{
    class Program
    {

        private string UserInputName { get; set; }
        private string _name { get; set; }


        //main function
        static void Main(string[] args){
            //opening of the game and creation of first user input
            //i think im misunderstanding something here
            //i want to create the hero object then give it a name but it wont update the property
            //Hero hero = new Hero();
            //Hero hero = new Hero("name");
            //hero.GetHeroName();
            //hero.PrintInfo();

            //this works to have a hero that has the property of the user input
            //maybe doing a list later?
            CreateMainStory();
            Console.WriteLine("Please Enter Hero name.");
            string _name = Console.ReadLine();
            Hero hero = new Hero(_name);
            Goblin gob = new Goblin("");
            gob.PrintInfo();
            


            //GetHeroName();//creates hero object hero
            
        }

        public static void CreateMainStory(){
            Console.WriteLine("|<--- Climb The Tower! --->|");
            Console.WriteLine();
            Console.ReadKey();

        }
        //i want to figure out how to create a hero object with user input for name
        //maybe create a HeroList class that is a list of heroes created using this function
        //let player display and choose hero




        //string _name = 
    }
    }




//
//tower rpg to test my own story and ideas
//idea is a town at the bottom of a tower
//this town has supplies to go to the tower
//tower has levels with rooms to explore and items to find
//

//create a person class and contructor for all enemies and heroes
//get user input for hero name 
//hero has 15 Health and 5 attack
//create enemy objects
//create the town class //user selection to go to different places

