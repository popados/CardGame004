using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame004.Cards;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CardGame004
{
    class CardTemplate : GameObject
    {
        #region fields
        private MouseState currentMouse;
        private SpriteFont _font;
        private bool _hovering;
        public bool _currentState;
        private MouseState previousMouse;
        private Texture2D _texture;
        private Card _card;
        private Vector2 _position;
        #endregion

        #region properties
        public int width;
        private bool _selected;

        public event EventHandler Click;

        public bool Clicked { get; set; }

        public Color PenColor { get; set; }

        public Vector2 Position { get; set; }

        public Vector2 NewPosition { get; set; }

        public string CardNameText { get; set; }

        public bool Dragging { get; set; }

        #endregion

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height);
            }
        }
        public Rectangle templateBox { get; set; }

        public CardTemplate(Texture2D texture, SpriteFont font, Card card)
        {
            _texture = texture;
            _font = font;
            _card = card;
            _position = Position;
            templateBox = new Rectangle((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height);

        }
        public void LoadContenet(ContentManager _content)
        {
            var templateTexture = _content.Load<Texture2D>("Assets/BlankFireCard");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var color = Color.White;
            if (Clicked)
                color = Color.Gray;
            if (_hovering)
                color = Color.DimGray;
            spriteBatch.Draw(_texture, templateBox, color);


            //card name string
            if (!string.IsNullOrEmpty(CardNameText))
            {
                var x = (Rectangle.X + (Rectangle.Width / 2)) - (_font.MeasureString(CardNameText).X / 2);
                //vertical string
                var y = (Rectangle.Y + (Rectangle.Height / 2)) - (_font.MeasureString(CardNameText).Y - 44);

                spriteBatch.DrawString(_font, CardNameText, new Vector2(x, y), Color.Black);
            }

        }
        public override void Update(GameTime gameTIme)
        {
            previousMouse = currentMouse;
            currentMouse = Mouse.GetState();

            var mouseRectangle = new Rectangle(currentMouse.X, currentMouse.Y, 1, 1);

            _hovering = false;

            if (templateBox.Contains(mouseRectangle)){
                Dragging = true;

                if (Dragging) {
                    templateBox = new Rectangle(currentMouse.X, currentMouse.Y,_texture.Width, _texture.Height);
                }
            }

            if (mouseRectangle.Intersects(Rectangle))
                _hovering = true;
                if (currentMouse.LeftButton == ButtonState.Released && previousMouse.LeftButton == ButtonState.Pressed)
                {
                    Click?.Invoke(this, new EventArgs());
                }
            }
        }

    }
