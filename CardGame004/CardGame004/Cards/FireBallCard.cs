using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame004.Cards
{
    public class FireBallCard : Card
    {
        //string CardName = "Fireball";
        //string CardDescription = "Fire in your face.";
        //string AbilityDescription = "Deal 1 damage to target creature/commander.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 1;
        public FireBallCard()
        {
            CardName = "Fireball";
            CardDescription = "Fire in your face.";
            AbilityDescription = "Deal 2 damage to target creature/commander.";
            CardType = "Spell";
            Attack = 2;
            Health = 0;
            Cost = 1;
            isCreature = false;
            summonSickness = false;
        }
    }
}
