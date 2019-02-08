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
    public class CreateHandState : State
    {
        private List<GameObject> _gameObject;
        Card player = new FireAvatar();
        //add objects here
        List<Card> deck = new List<Card>
            {
            //deck created with card objects
                new ImpCard(), new ImpCard(), new ImpCard(),
                new LittleDraco(), new LittleDraco(), new LittleDraco(),
                new SpiritOFire(), new SpiritOFire(), new SpiritOFire(),
                new FireDrake(), new FireDrake(), new FireDrake(),
                new FireBall(), new FireBall(), new FireBall(),
                new FlameStrike(), new FlameStrike(), new FlameStrike(),
                new WildFire(), new WildFire(), new WildFire() };

        List<Card> shuffled = new List<Card>();
        List<Card> startHand = new List<Card>();
        List<Card> fieldArea = new List<Card>();

        Random ran = new Random();



public CreateHandState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Assets/button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");

            Card player = new FireAvatar();

            int count = deck.Count();
            int selection = 0;

            for (int i = 0; i < count; i++)
            {
                selection = ran.Next(deck.Count - 1);
                shuffled.Add(deck[selection]);
                deck.RemoveAt(selection);
            }

            int drawSize = 3;
            int deckIndex = shuffled.Count();

            for (int i = 0; i < drawSize; i++)
            {
                startHand.Add(shuffled[0]);
                shuffled.RemoveAt(0);
            }

            //create empty field area
            //

            //create empty hand of cards


            //buttons are selected from the hand
            var cardOneHand = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(0, 0),
                Text = startHand[0].CardName,
            };
            cardOneHand.Click += CardOneHand_Click;
            var cardTwoHand = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(0, 100),
                Text = startHand[1].CardName,
            };
            var cardThreeHand = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(0, 200),
                Text = startHand[2].CardName,
            };


            //phases buttons
            var MainPhaseButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(920, 100),
                Text = "MainPhase",
            };
            var DrawPhaseButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(920, 200),
                Text = "MainPhase",
            };
            var CombatPhaseButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(920, 300),
                Text = "MainPhase",
            };
            var EndTurnButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(920, 400),
                Text = "MainPhase",
            };

            _gameObject = new List<GameObject>()
                    {
                cardOneHand,
                cardTwoHand,
                cardThreeHand,
                MainPhaseButton,
                DrawPhaseButton,
                CombatPhaseButton,
                EndTurnButton
                //loadGameButton,
                //exitGameButton
            };
        }

        private void CardOneHand_Click( object sender, EventArgs e)
        {
            player.Health -= startHand[0].Attack;
            if (player.Health <= 0) {
                _game.ChangeState(new MenuState(_game, _graphicsDevice, _content));
            }
        }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //Card player = new FireAvatar();
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");
            spriteBatch.Begin();
            spriteBatch.DrawString(buttonFont,player.CardDescription +"\n "+ player.CardName,new Vector2(400,400),Color.Black);
            spriteBatch.DrawString(buttonFont,"Health: "+ player.Health, new Vector2(400, 500), Color.Black);
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


//var newGameButton = new Button(buttonTexture, buttonFont)
//{
//    Position = new Vector2(300, 100),
//    Text = "New Game",
//};
//newGameButton.Click += NewGameButton_Click;

            //    var loadGameButton = new Button(buttonTexture, buttonFont)
            //    {
            //        Position = new Vector2(300, 225),
            //        Text = "Load Game",
            //    };
            //    loadGameButton.Click += LoadGameButton_Click;

            //    var exitGameButton = new Button(buttonTexture, buttonFont)
            //    {
            //        Position = new Vector2(300, 350),
            //        Text = "Exit Game",
            //    };
            //    exitGameButton.Click += ExitGameButton_Click;
        //private void NewGameButton_Click(object sender, EventArgs e)
        //{
        //    _game.ChangeState(new DisplayCardState(_game, _graphicsDevice, _content));
        //}

        //private void LoadGameButton_Click(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Load Game");
        //}

        //private void ExitGameButton_Click(object sender, EventArgs e)
        //{
        //    _game.Exit();
        //}
