using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerRPG
{
    class Hero : Person
    {
        private string UserInputName { get; set; }
        private int _health;

        public Hero(string _name) : base(_name)
        {


        }
        public Hero GetHeroName()
        {
            //string UserInputName = _name;
            Console.WriteLine("Please Enter Hero name.");
            string _name = Console.ReadLine();
            Hero hero = new Hero(_name);
            hero.PrintInfo();
            return hero;
        }
    }
}
