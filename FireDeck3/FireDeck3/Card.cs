
//        public void Print()
//        {
//            Console.WriteLine("Card: " + CardName +
//                "\n Description: " + CardDescription +
//                "\n Ability: " + AbilityDescription +
//                "\n Type: " + CardType +
//                "\n int Attack: " + int Attack +
//                "\n int Health: " + int Health +
//                "\n Cost: " + Cost);
//            Console.WriteLine();
//            Console.ReadKey();
//        }
//        public void Name() {
//            Console.WriteLine("Name: " + CardName);
//        }
//    }
//}
    ////}

    /* NEW TEST */

    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDeck3
{
    public class Card
    {
        //variables for cards
        public string CardName { get; set; }
        public string CardDescription { get; set; }
        public string AbilityDescription { get; set; }
        public string CardType { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Cost { get; set; }
        public bool isDead { get; set; }
        public bool summonSickness { get; set; }

        //constructor for cards with default values
        //all cards are created as Card card = new CardName();
        //all commented out code between class and constructor in inheirented classes is for saving
        public Card()
        {
            CardName = "Card Name";
            CardDescription = "Card Description";
            AbilityDescription = "N/A";
            CardType = "Creature or Spell";
            Attack = 0;
            Health = 0;
            Cost = 0;
        }

        public override string ToString()
        {
            return ":--" + CardName + "--:" ;
            //+ "\t Mana Cost: " + Cost
        }
    }
    public class ImpCard : Card
    {
        //string CardName = "Imp";
        //string CardDescription = "Totally not a Warlock pet.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 1;
        //int Cost = 1;
        public ImpCard()
        {
            CardName = "Imp";
            CardDescription = "Totally not a Warlock pet.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 1;
            Cost = 1;
        }
    }
    public class LittleDraco : Card
    {
        //string CardName = "Little Draco";
        //string CardDescription = "Small Dragon.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 1;
        //int Health = 3;
        //int Cost = 1;
        public LittleDraco()
        {
            CardName = "Little Draco";
            CardDescription = "Small Dragon.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 1;
            Health = 3;
            Cost = 1;
        }
    }
    public class SpiritOFire : Card
    {
        //string CardName = "Spirit Of Fire";
        //string CardDescription = "Its the spirit of da fire, mon.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 4;
        //int Cost = 2;
        public SpiritOFire()
        {
            CardName = "Spirit Of Fire";
            CardDescription = "Its the spirit of da fire, mon.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 4;
            Cost = 2;
        }
    }
    public class FireDrake : Card
    {
        //string CardName = "Fire Drake";
        //string CardDescription = "Big Big Dragon.";
        //string AbilityDescription = "+1/+1 for each Little Draco in play.";
        //string CardType = "Creature";
        //int Attack = 5;
        //int Health = 3;
        //int Cost = 3;
        public FireDrake()
        {
            CardName = "Fire Drake";
            CardDescription = "Big Big Dragon.";
            AbilityDescription = "+1/+1 for each Little Draco in play.";
            CardType = "Creature";
            Attack = 5;
            Health = 3;
            Cost = 3;
        }
    }

    public class FireBall : Card
    {
        //string CardName = "Fireball";
        //string CardDescription = "Fire in your face.";
        //string AbilityDescription = "Deal 1 damage to target creature/commander.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 1;
        public FireBall()
        {
            CardName = "Fireball";
            CardDescription = "Fire in your face.";
            AbilityDescription = "Deal 1 damage to target creature/commander.";
            CardType = "Spell";
            Attack = 0;
            Health = 0;
            Cost = 1;
        }
    }
    public class FlameStrike : Card
    {
        //string CardName = "Flamestrike";
        //string CardDescription = "Fire strikes the earth.";
        //string AbilityDescription = "1 damage three times to random enemies.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 3;
        public FlameStrike()
        {
            CardName = "Flamestrike";
            CardDescription = "Fire strikes the earth.";
            AbilityDescription = "1 Damage to three creatures.";
            CardType = "Spell";
            Attack = 0;
            Health = 0;
            Cost = 2;
        }
    }
    public class WildFire : Card
    {
        //string CardName = "Wildfire";
        //string CardDescription = "Uncontrollable flames.";
        //string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 2;
        public WildFire()
        {
            CardName = "Wildfire";
            CardDescription = "Uncontrollable flames.";
            AbilityDescription = "Deal 2 damage to all creatures and commanders.";
            CardType = "Spell";
            Attack = 0;
            Health = 0;
            Cost = 3;
        }
    }
}

    //}
    //public class Pigeon : Card
    //{
    //    string CardName = "Wildfire";
    //    string CardDescription = "Uncontrollable flames.";
    //    string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
    //    string CardType = "Spell";
    //    int Attack = 0;
    //    int Health = 0;
    //    int Cost = 2;            
    //}
    //public class LittleGriff : Card
    //{
    //    string CardName = "Wildfire";
    //    string CardDescription = "Uncontrollable flames.";
    //    string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
    //    string CardType = "Spell";
    //    int Attack = 0;
    //    int Health = 0;
    //    int Cost = 2;
    //}
    //public class SpiritOfWind : Card
    //{
    //    string CardName = "Wildfire";
    //    string CardDescription = "Uncontrollable flames.";
    //    string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
    //    string CardType = "Spell";
    //    int Attack = 0;
    //    int Health = 0;
    //    int Cost = 2;
    //}
    //public class SkyGriffin : Card
    //{
    //    string CardName = "Wildfire";
    //    string CardDescription = "Uncontrollable flames.";
    //    string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
    //    string CardType = "Spell";
    //    int Attack = 0;
    //    int Health = 0;
    //    int Cost = 2;            
    //}
    //public class Gale : Card
    //{
    //    string CardName = "Wildfire";
    //    string CardDescription = "Uncontrollable flames.";
    //    string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
    //    string CardType = "Spell";
    //    int Attack = 0;
    //    int Health = 0;
    //    int Cost = 2;
    //}
    //public class Tornado : Card
    //{
    //    string CardName = "Wildfire";
    //    string CardDescription = "Uncontrollable flames.";
    //    string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
    //    string CardType = "Spell";
    //    int Attack = 0;
    //    int Health = 0;
    //    int Cost = 2;
    //}
    //public class BirdsOfFeather : Card
    //{
    //    string CardName = "Wildfire";
    //    string CardDescription = "Uncontrollable flames.";
    //    string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
    //    string CardType = "Spell";
    //    int Attack = 0;
    //    int Health = 0;
    //    int Cost = 2;        
    //}
