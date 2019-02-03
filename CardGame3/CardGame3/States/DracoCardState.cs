using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CardGame3.States
{
    public class DracoCardState : State
    {
        private List<GameObject> _gameObject;

        public DracoCardState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            //var buttonTexture = _content.Load<Texture2D>("Assets/button");
            //var buttonFont = _content.Load<SpriteFont>("Fonts/Font");

            ////buttons from tutorial that showed me how to use states
            //var exitGameButton = new Button(buttonTexture, buttonFont)
            //{
            //    Position = new Vector2(950, 300),
            //    Text = "Exit Game",
            //};
            //exitGameButton.Click += ExitGameButton_Click;
            //var menuGameButton = new Button(buttonTexture, buttonFont)
            //{
            //    Position = new Vector2(950, 200),
            //    Text = "Main Menu",
            //};
            //menuGameButton.Click += MenuGameButton_Click;
            //var cardsButton = new Button(buttonTexture, buttonFont)
            //{
            //    Position = new Vector2(950, 100),
            //    Text = "Cards Menu",
            //};
            //cardsButton.Click += CardsButton_Click;
            //_gameObject = new List<GameObject>()
            //    {
            //    cardsButton,
            //    exitGameButton,
            //    menuGameButton
            //    };
        }

        private void CardsButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new DisplayCardState(_game, _graphicsDevice, _content));
        }

        public void MenuGameButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new MenuState(_game, _graphicsDevice, _content));
        }

        public void ExitGameButton_Click(object sender, EventArgs e)
        {
            _game.Exit();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var buttonTexture = _content.Load<Texture2D>("Assets/button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");

            Card draco = new LittleDraco();

            //draw the buttons in the game object
            spriteBatch.Begin();
            foreach (var gameObject in _gameObject)
                gameObject.Draw(gameTime, spriteBatch);
            spriteBatch.End();

            ShowHand(spriteBatch, buttonFont, draco);

        }

        public override void PostUpdate(GameTime gameTime)
        {

        }

        public override void Update(GameTime gameTime)
        {

            foreach (var gameObject in _gameObject)
                gameObject.Update(gameTime);

        }
        public static void ShowHand(SpriteBatch spriteBatch,SpriteFont buttonFont, Card draco ) {
            spriteBatch.Begin();
            spriteBatch.DrawString(buttonFont, "Name: " + draco.CardName, new Vector2(0, 100), Color.Black);
            spriteBatch.DrawString(buttonFont, "Ability: " + draco.AbilityDescription, new Vector2(0, 150), Color.Black);
            spriteBatch.DrawString(buttonFont, "Description: " + draco.CardDescription, new Vector2(0, 200), Color.Black);
            spriteBatch.DrawString(buttonFont, "Attack: " + draco.Attack, new Vector2(0, 250), Color.Black);
            spriteBatch.DrawString(buttonFont, "Health: " + draco.Health, new Vector2(0, 300), Color.Black);
            spriteBatch.DrawString(buttonFont, "Type: " + draco.CardType, new Vector2(0, 350), Color.Black);
            spriteBatch.End();
        }

    }
}
