using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame004.Cards
{
    public class SpiritOFireCard : Card
    {
        //string CardName = "Spirit Of Fire";
        //string CardDescription = "Its the spirit of da fire, mon.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 3;
        //int Health = 4;
        //int Cost = 2;
        public SpiritOFireCard()
        {
            CardName = "Spirit Of Fire";
            CardDescription = "Its the spirit of da fire, mon.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 3;
            Health = 4;
            Cost = 2;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //if spirit fire dies(last will) {1 damage}
        }
    }
}
