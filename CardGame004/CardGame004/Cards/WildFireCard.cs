using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CardGame004.Cards
{
    public class WildFireCard : Card
    {
        //string CardName = "Wildfire";
        //string CardDescription = "Uncontrollable flames.";
        //string AbilityDescription = "Deal 2 damage to enemy creatures and commanders.";
        //string CardType = "Spell";
        //int Attack = 0;
        //int Health = 0;
        //int Cost = 2;
        public WildFireCard()
        {
            CardName = "Wildfire";
            CardDescription = "Uncontrollable flames.";
            AbilityDescription = "Deal 2 damage to all creatures and commanders.";
            CardType = "Spell";
            Attack = 2;
            Health = 0;
            Cost = 3;
            isCreature = false;
            //no summon sickness for spells
            //for each field area // etc //etc
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTIme)
        {
            throw new NotImplementedException();
        }
    }
}
