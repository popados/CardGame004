using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame004.Cards
{
    public abstract class Card
    {
        //variables for cards
        public string CardName { get; set; }
        public string CardDescription { get; set; }
        public string AbilityDescription { get; set; }
        public string CardType { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Cost { get; set; }
        public int maxMana { get; set; }
        public int currentMana { get; set; }
        public int playerTurnCount { get; set; }
        public bool playerTurn { get; set; }
        public bool isDead { get; set; }
        public bool summonSickness { get; set; }
        public bool isCreature { get; set; }

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont arial;
        private Color _backgroundColor = Color.CornflowerBlue;
        //private List<GameObject> gameObjects;
        //constructor for cards with default values
        //all cards are created as Card card = new CardName();
        //all commented out code between class and constructor in inheirented classes is for saving
        public Card()
        {
            CardName = "Card Name";
            CardDescription = "Card Description";
            AbilityDescription = "N/A";
            CardType = "Creature or Spell";
            Attack = 0;
            Health = 0;
            Cost = 0;
            isCreature = false;
            summonSickness = false;
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(arial, "Display Cards: ", new Vector2(925, 0), Color.Black);
            spriteBatch.DrawString(arial, "Card Name: ", new Vector2(250, 50), Color.Black);
            spriteBatch.End();
        }
        public override string ToString()
        {
            return ":--" + CardName + "--:";
            //+ "\t Mana Cost: " + Cost
        }
        //public void createButton(ContentManager content) {
        //    var buttons =
        //        new Button(content.Load<Texture2D>("Assets/button"), content.Load<SpriteFont>("Fonts/Font"))
        //        {
        //            Position = new Vector2(0, 0),
        //            Text = "" + CardName,
        //        };
        //}

        public void printCard()
        {
            Console.WriteLine("Card: " + CardName +
                 "\n Description: " + CardDescription +
                "\n Ability: " + AbilityDescription +
                "\n Type: " + CardType +
                "\n Attack: " + Attack +
                "\n Health: " + Health +
                "\n Cost: " + Cost +
                "\n Just summoned: " + summonSickness);
            Console.WriteLine();
            //Console.ReadKey();
        }
    }
}
