using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerRPG
{
    public class Enemy : Person
    {
        public Enemy(string _name):base (_name) {
            
        }
    }

    public class Goblin : Enemy {
        public Goblin(string _name) : base(_name) {
            _name = "Goblin";
            
        }
    }
}
