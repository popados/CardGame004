using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownRPG_001.Actors
{
    public class Actor
    {
        public string ActorName { get; set; }
        public string ActorDescription { get; set; }

        public int ActorLevel { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int Wisdom { get; set; }

        public bool IsDead { get; set; }
        public bool IsCreature { get; set; }
        public bool IsPlayer { get; set; }

        //constructor
        public Actor()
        {
            ActorName = "Dummy Actor Name";
            ActorDescription = "Actor's Description";

            Strength = 0;
            Dexterity = 0;
            Intelligence = 0;
            Charisma = 0;
            Wisdom = 0;

            IsDead = false;
            IsCreature = false;
            IsPlayer = false;
        }

        public void Print()
        {
            Console.WriteLine("Actor Name: " + ActorName +
                "\nActor Description: " + ActorDescription +
                "\nStrength: " + Strength +
                "\nDexterity: " + Dexterity +
                "\nIntelligence: " + Intelligence +
                "\nCharisma: " + Charisma +
                "\nWisdom: " + Wisdom);
        }
    }
}
