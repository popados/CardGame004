﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CardGame004.Cards
{
    public class LittleDracoCard : Card
    {
        //string CardName = "Little Draco";
        //string CardDescription = "Small Dragon.";
        //string AbilityDescription = "N/A";
        //string CardType = "Creature";
        //int Attack = 1;
        //int Health = 3;
        //int Cost = 1;
        public LittleDracoCard()
        {
            CardName = "Little Draco";
            CardDescription = "Small Dragon.";
            AbilityDescription = "N/A";
            CardType = "Creature";
            Attack = 1;
            Health = 3;
            Cost = 1;
            isCreature = true;
            isDead = false;
            summonSickness = false;
            //nothing will use card name for fire drake

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
