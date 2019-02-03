using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


//What to do now?
//each card can be a different state that displays the info?
//do I want to have a draw/play card area that deals cards randomly out to your hand
//the hand has an area and when a card is clicked it goes through a series of checks
//to create a hand I need to assign all the cards to a deck list that is hidden
//create buttons for the hand
//a hand will have 3 starting cards
//the "play area" will have
//hand[]
//mana count[]
//commander hp[]
//end turn[]
//play card[]

//need to create states
//play area[]
//create hand[]
//play card[]
//

//create a hand from a list of cards
//hand list
//deck list
//buttons created for hand
//buttons for each card
//first create deck
//create hand
//take shuffle and random selection formulas
//each hand creates cardhandn.CardName for the button text
//
//ive got game objects that use draw and update
//state that updates like the game
//inside game1 loads the states that are the same as the game1
//game1 uses init and loadcontent
//each file can base 

namespace CardGame3.States
{
    public class DisplayCardState : State
    {
        private List<GameObject> _gameObject;

        Card imp = new ImpCard();
        Card draco = new LittleDraco();
        Card spirit = new SpiritOFire();
        Card drake = new FireDrake();

        public DisplayCardState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Assets/button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");




            var impButton =
                new Button(buttonTexture, buttonFont)
                {
                    Position = new Vector2(0, 0),
                    Text = imp.CardName,
                };
            var drakeButton =
                new Button(buttonTexture, buttonFont)
                {
                    Position = new Vector2(0, 100),
                    Text = draco.CardName,
                };
            drakeButton.Click += DrakeButton_Click;
            var SpiritOfFireButton =
                new Button(buttonTexture, buttonFont)
                {
                    Position = new Vector2(0, 200),
                    Text = spirit.CardName,
                };
            var FireDrakeButton =
                new Button(buttonTexture, buttonFont)
                {
                    Position = new Vector2(0, 300),
                    Text = drake.CardName,
                };
            var FireBallButton =
                new Button(buttonTexture, buttonFont)
                {
                    Position = new Vector2(0, 400),
                    Text = "Fireball",
                };
            var FireStrikeButton =
                new Button(buttonTexture, buttonFont)
                {
                    Position = new Vector2(0, 500),
                    Text = "FlameStrike",
                };
            var WildFireButton =
                new Button(buttonTexture, buttonFont)
                {
                    Position = new Vector2(0, 600),
                    Text = "WildFire",
                };
            var exitGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(975, 0),
                Text = "Exit Game",
            };
            var createHandButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(975, 150),
                Text = "Create Hand",
            };
            createHandButton.Click += CreateHandButton_Click;

            _gameObject = new List<GameObject>()
                {
                impButton,
                drakeButton,
                SpiritOfFireButton,
                FireDrakeButton,
                FireBallButton,
                FireStrikeButton,
                WildFireButton,
                createHandButton,
                exitGameButton
                };

        }

        private void DrakeButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Test");
            draco.printCard();
            _game.ChangeState(new DracoCardState(_game, _graphicsDevice, _content));
        }
        private void CreateHandButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Test");
            draco.printCard();
            _game.ChangeState(new CreateHandState(_game, _graphicsDevice, _content));
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            _game.Exit();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            foreach (var gameObject in _gameObject)
                gameObject.Draw(gameTime, spriteBatch);
            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gameTime)
        {

        }

        public override void Update(GameTime gameTime)
        {
            foreach (var gameObject in _gameObject)
                gameObject.Update(gameTime);
        }
    }
}
