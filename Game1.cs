using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_2___Scaling_and_Text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Rectangle window;
        Texture2D circleTexture;
        Texture2D rectangleTexture;
        Rectangle rect1;
        Rectangle magentaRect;
        Rectangle circleRect;
        SpriteFont textFont;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            window = new Rectangle(0, 0, 800, 500);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();
            rect1 = new Rectangle(50, 50, 100, 100);
            magentaRect = new Rectangle(420, 61, 67, 69);
            circleRect = new Rectangle(200, 67, 61, 420);
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            textFont = Content.Load<SpriteFont>("textFont");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(rectangleTexture, rect1, Color.White);
            _spriteBatch.Draw(rectangleTexture, magentaRect, Color.Magenta);
            _spriteBatch.Draw(circleTexture, circleRect, Color.White);
            _spriteBatch.DrawString(textFont, "Yo, Gurt!", new Vector2(100, 100), Color.Goldenrod);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
