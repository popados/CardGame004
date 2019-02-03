using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerRPG
{

    public class Person
    {
        private string CharacterName{ get; set; }
        private int Health { get; set; }
        private int Attack { get; set; }

        //constructor
        public Person(string _name) {
            CharacterName = _name;
            Health = 15;
            Attack = 5;
        }
        //function to print
        public void PrintInfo() {
            Console.WriteLine("Name: " + CharacterName);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Attack Power: " + Attack);
            Console.ReadKey();
        }
    }
}
