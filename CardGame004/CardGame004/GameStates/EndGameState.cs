using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame004;
using CardGame004.Cards;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CardGame004.States
{
    public class EndGameState : State
    {
        private List<GameObject> gameObjects;

        public EndGameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {

            Card imp = new ImpCard();
            Card draco = new LittleDracoCard();
            Card spirit = new SpiritOFireCard();

            var buttonTexture = _content.Load<Texture2D>("Assets/button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");
            var templateTexture = _content.Load<Texture2D>("Assets/BlankFireCard");
            Viewport viewport = graphicsDevice.Viewport;

            var DrawCardButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(125, 0),
                Text = "Draw",
                _currentState = false,
            };
            var MainPhaseButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(250, 0),
                Text = "Main",
                _currentState = false,
            };
            var CombatPhaseButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(375, 0),
                Text = "Combat",
                _currentState = false,
            };
            var EndPhaseButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(500, 0),
                Text = "End",
                _currentState = true,
            };
            var NextPhaseButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(500, 400),
                Text = "Next",
                _currentState = false,
            };


            var firstCard = new CardTemplate(templateTexture, buttonFont, imp)
            {

                Position = new Vector2(viewport.Width - viewport.Width + templateTexture.Width - templateTexture.Width, 300),
                CardNameText = imp.CardName,
            };


            var secondCard = new CardTemplate(templateTexture, buttonFont, spirit)
            {
                Position = new Vector2(viewport.Width - viewport.Width + templateTexture.Width, 300),
                CardNameText = spirit.CardName,
            };
            var thirdCard = new CardTemplate(templateTexture, buttonFont, draco)
            {
                Position = new Vector2(viewport.Width - viewport.Width + templateTexture.Width + templateTexture.Width, 300),
                CardNameText = draco.CardName,
            };

            NextPhaseButton.Click += NextPhaseButton_Click;
            // Create a new SpriteBatch, which can be used to draw textures.
            gameObjects = new List<GameObject>() {
                DrawCardButton,
                MainPhaseButton,
                CombatPhaseButton,
                EndPhaseButton,
                NextPhaseButton,
                firstCard,
                secondCard,
                thirdCard
            };

        }

        private void NextPhaseButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new DrawGameState(_game, _graphicsDevice, _content));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (var GameObject in gameObjects)
            {
                GameObject.Draw(gameTime, spriteBatch);
            }
            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gameTime)
        {

        }

        public override void Update(GameTime gameTime)
        {

            foreach (var GameObject in gameObjects)
            {
                GameObject.Update(gameTime);
            }
        }

    }
}
