using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame004.Cards
{
    public class FlameStrikeCard : Card
    {
        //string CardName = "Flamestrike";
        //string CardDescription = "Fire strikes the earth.";
        //string AbilityDescription = "1 damage three times to random enemies.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 3;
        public FlameStrikeCard()
        {
            CardName = "Flamestrike";
            CardDescription = "Fire strikes the earth.";
            AbilityDescription = "1 Damage to three creatures.";
            CardType = "Spell";
            Attack = 1;
            Health = 0;
            Cost = 2;
            isCreature = false;
            //for each card in field area list [i] = random ran for index//
            //add enemy to list
            //no summon sickness for spells
        }
    }
}
