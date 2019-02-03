using CardGame3.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace CardGame3
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    /// 
    //TODO//
    //Create card container that holds the card before 
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private State _currentState;

        private State _nextState;

        public void ChangeState(State state) {
            _nextState = state;
        }

        SpriteFont arial;

        private Color _backgroundColor = Color.CornflowerBlue;
        private List<GameObject> _gameObjects;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Window.Title = "Card Game";
            this.IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 1200;
            graphics.PreferredBackBufferHeight = 700;
            graphics.ApplyChanges();
            //Card imp = new ImpCard();

            List<Card> deck = new List<Card>
            {
            //deck created with card objects
                new ImpCard(),//new ImpCard(), new ImpCard(),
                new LittleDraco(),//new LittleDraco(), new LittleDraco(),
                new SpiritOFire(),//new SpiritOFire(), new SpiritOFire(),
                new FireDrake(),//new FireDrake(), new FireDrake(),
                new FireBall(),//new FireBall(), new FireBall(),
                new FlameStrike(),//new FlameStrike(), new FlameStrike(),
                new WildFire()//, new WildFire(), new WildFire() 
            };
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            //create hand here

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            _currentState = new MenuState(this, graphics.GraphicsDevice, Content);

            //drawButtons();


        }

        //private void RandomButton_Click(object sender, EventArgs e)
        //{
        //    Card cardDisplay = new ImpCard();
        //    cardDisplay.Draw(spriteBatch);
        //    throw new Exception();
        //}

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (_nextState != null) {
                _currentState = _nextState;
                _nextState = null;
            }

            _currentState.Update(gameTime);

            _currentState.PostUpdate(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            Card cardDisplay = new ImpCard();

            _currentState.Draw(gameTime, spriteBatch);

            //spriteBatch.Begin();
            //spriteBatch.DrawString(arial, "Display Cards: " + cardDisplay.CardName, new Vector2(925, 0), Color.Black);
            //spriteBatch.DrawString(arial, "Card Name: ", new Vector2(250, 50), Color.Black);
            //updating methods for the buttons clicked to display info
            //when button clicked change the display with a new function that displays new info

            //Card testCard = new ImpCard();
            //testCard.createButton(this.Content);

            //foreach (var GameObject in _gameObjects)
            //{
            //    GameObject.Draw(gameTime, spriteBatch);
            //}
            //spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
        //public void drawButtons()
        //{
        //    all the cards in the deck

    }
}
//    Card impCard = new ImpCard();
//    Card DracoCard = new LittleDraco();
//    Card SpiritFire = new SpiritOFire();
//    Card FireDrake = new FireDrake();
//    Card FireBall = new FireBall();
//    Card FlameStrike = new FlameStrike();
//    Card WildFire = new WildFire();
//    TODO: use this.Content to load your game content here

//    arial = Content.Load<SpriteFont>("Fonts/Font");

//    Card cardDisplay = new ImpCard();



//    button.Click to function randomButton_click
//    Creates a click that displays the card of the right

//    buttons.Click += RandomButton_Click;


//    gameObjects = new List<GameObject>() {
//        buttons,
//    drakeButton,SpiritOfFireButton,FireDrakeButton,FireBallButton,FireStrikeButton,WildFireButton
//};
//}