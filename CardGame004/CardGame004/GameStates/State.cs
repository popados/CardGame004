using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame004;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CardGame004.States
{
    public abstract class State
    {
        #region fields
        protected ContentManager _content;

        protected GraphicsDevice _graphicsDevice;

        protected Game1 _game;

        #endregion

        #region Methods

        public abstract void Draw(GameTime gametime, SpriteBatch spriteBatch);

        public abstract void PostUpdate(GameTime gameTime);

        public State(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
        {
            _game = game;

            _graphicsDevice = graphicsDevice;

            _content = content;

        }

        public abstract void Update(GameTime gameTime);

        #endregion

    }
}
