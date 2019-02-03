using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CardGame004.Cards.Avatar
{
    public class FireAvatar : Card
    {
        public FireAvatar()
        {
            CardName = "Atria, the Phoenix of Rebirth";
            CardDescription = "Commander of Fire. Edge and all.";
            AbilityDescription = "I AM THE COMMANDER! HAhaAhaA.";
            CardType = "Hero/Avatar";
            Attack = 0;
            Health = 15;
            Cost = 0;
            maxMana = 5;
            currentMana = 1;
            playerTurnCount = 0;
            playerTurn = false;
            isCreature = false;
            //no summon sickness for spells
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
