using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame004;
using CardGame004.Cards;
using CardGame004.Cards.Avatar;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CardGame004.States
{
    public class DrawGameState : State
    {
        private List<GameObject> gameObjects;
        public int turnCount { get; set; }
        public bool changeState = false;
        public MouseState currentMouse;


        // new FireDrake(), new FireDrake(), new FireDrake(),
        //  new FireBall(), new FireBall(), new FireBall(),
        //  new FlameStrike(), new FlameStrike(), new FlameStrike(),
        // WildFire(), new WildFire(), new WildFire() };

        Card imp = new ImpCard();
        Card draco = new LittleDracoCard();
        Card spirit = new SpiritOFireCard();
        FireAvatar avatar = new FireAvatar();
        private bool _selected;

        public DrawGameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Assets/button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");
            var templateTexture = _content.Load<Texture2D>("Assets/BlankFireCard");
            Viewport viewport = graphicsDevice.Viewport;

            var DrawCardButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(125, 0),
                Text = "Draw",
                _currentState = true,
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
                _currentState = false,
            };


            var firstCard = new CardTemplate(templateTexture, buttonFont, imp)
            {

                Position = new Vector2(viewport.Width - viewport.Width + templateTexture.Width - templateTexture.Width, 300),
                CardNameText = imp.CardName,

                
            };
            firstCard.Click += FirstCard_Click;

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


            //card template/buttons


            //TODO
            //Create a deck class that contains 3 copies of the 7 cards
            //card templates for a hand
            //foreach card in hand { // create template }
            //create a play action for each
            //create a template object for the card
            //when an object is added to the hand it is given a card object
            //the hand is hand.width / 2 for each button
            //clear drawstring method with a click
            //create a hand that is displayed on all states(new list of objects created from another class)
            //inside deck class create my list of cards
            //each card class will have a template function associated with it that creates 
            //


            var NextPhaseButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(500, 400),
                Text = "Next",
                
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

        private void FirstCard_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            avatar.Health -= imp.Attack;
            if (avatar.Health <= 0)
            {
                _game.ChangeState(new MainState(_game, _graphicsDevice, _content));
            }
        }


        private void NextPhaseButton_Click(object sender, EventArgs e)
        {
            changeState = true;
            if (currentMouse.LeftButton == ButtonState.Pressed && currentMouse.LeftButton != ButtonState.Released)
            {
                var end = new Vector2(currentMouse.X, currentMouse.Y);
                if (currentMouse.LeftButton == ButtonState.Released)
                {
                    var start = end;

                }
                else
                {
                    _selected = false;
                }
                //turnCount++;
                _game.ChangeState(new MainState(_game, _graphicsDevice, _content));
            }
        }



        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");
            Card card = new ImpCard(); 
            spriteBatch.Begin();
            spriteBatch.DrawString(buttonFont, "Commander HP: " + avatar.Health, new Vector2(0, 200), Color.Black);


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
            turnCount++;
            foreach (var GameObject in gameObjects)
            {
                GameObject.Update(gameTime);
            }
        }
        public static void cardClicked(FireAvatar avatar, Card imp) {
            //damage

        }
    }
}
