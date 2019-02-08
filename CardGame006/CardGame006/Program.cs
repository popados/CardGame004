using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame006
{
    class Card
    {
        public string cardName { get; set; }
        public int cardHealth { get; set; }
        public int cardPower;
        public int cardCost;

    
    public void PrintCard()
    {
            Console.WriteLine("Card Name: " + cardName +
                "\nCard Health: " + cardHealth +
                "\nCard Power: " + cardPower +
                "\nCard Cost: " + cardCost );
    }
    

    public Card(string name ,int health, int power, int cost)
    {
        cardName = name;
        cardHealth = health;
        cardPower = power;
        cardCost = cost;
    }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //create all the cards
            Card imp = new Card("Imp", 1, 3, 1);
            //imp.PrintCard();

            Console.WriteLine("\nView Cards? Press 1 for yes 2 for no.");
            var input = Console.ReadLine();
            Int32.TryParse(input, out int result);
            switch (result)
            {
                case 1:
                    imp.PrintCard();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("nothing here");
                    //ends
                    //send into a function for while loop
                    break;
            }
        }
    }

}
