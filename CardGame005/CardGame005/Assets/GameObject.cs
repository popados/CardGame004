using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CardGame005.Assets
{
    public abstract class GameObject
    {
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
        public abstract void Update(GameTime gameTIme);
    }
}
