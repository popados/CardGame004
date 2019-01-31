﻿using System;
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
    public class DrawGameState : State
    {
        private List<GameObject> gameObjects;

        public DrawGameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {

            var buttonTexture = _content.Load<Texture2D>("Assets/button");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");


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

            //TODO
            //Create a deck class that contains 3 copies of the 7 cards
            //card templates for a hand
            //foreach card in hand { // create template }
            //create a play action for each
            //create a template object for the card
            //when an object is added to the hand it is given a card object
            //the hand is hand.width / 2 for each button
            //clear drawstring method with a click
            //




            var NextPhaseButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(500, 400),
                Text = "Next",
                _currentState = false,
            };
            NextPhaseButton.Click += NextPhaseButton_Click;
            // Create a new SpriteBatch, which can be used to draw textures.
            gameObjects = new List<GameObject>() {
                DrawCardButton,
                MainPhaseButton,
                CombatPhaseButton,
                EndPhaseButton,
                NextPhaseButton
            };
        }

        private void NextPhaseButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new MainState(_game, _graphicsDevice, _content));
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