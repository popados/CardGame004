using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame004.Cards
{
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
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing but an attack
        }
    }
}
