using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpriteFontSample01
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont Kootenay14;
        SpriteFont Miramonte14;
        SpriteFont MiramonteBold14;
        SpriteFont PERICLES14;
        SpriteFont PERICLESLIGHT14;
        SpriteFont lindsey14;
        SpriteFont Pescadero14;
        SpriteFont PescaderoBold14;
        SpriteFont SegoeUIMono14;
        SpriteFont SegoeUIMonoBold14;
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

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Kootenay14 = Content.Load<SpriteFont>("Kootenay14");
            Miramonte14 = Content.Load<SpriteFont>("Miramonte14");
            MiramonteBold14 = Content.Load<SpriteFont>("MiramonteBold14");
            PERICLES14 = Content.Load<SpriteFont>("PERICLES14");
            PERICLESLIGHT14 = Content.Load<SpriteFont>("PERICLESLIGHT14");
            lindsey14 = Content.Load<SpriteFont>("lindsey14");
            Pescadero14 = Content.Load<SpriteFont>("Pescadero14");
            PescaderoBold14 = Content.Load<SpriteFont>("PescaderoBold14");
            SegoeUIMono14 = Content.Load<SpriteFont>("SegoeUIMono14");
            SegoeUIMonoBold14 = Content.Load<SpriteFont>("SegoeUIMonoBold14");
            // TODO: use this.Content to load your game content here
        }

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
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.DrawString(Kootenay14, "Hello MonoGame \r http://www.xnadevelop.com", Vector2.Zero, Color.White);
            spriteBatch.DrawString(Miramonte14, "Hello MonoGame \r http://www.xnadevelop.com", new Vector2(0,40), Color.White);
            spriteBatch.DrawString(MiramonteBold14, "Hello MonoGame \r http://www.xnadevelop.com", new Vector2(0, 80), Color.White);
            spriteBatch.DrawString(PERICLES14, "Hello MonoGame \r http://www.xnadevelop.com", new Vector2(0, 120), Color.White);
            spriteBatch.DrawString(PERICLESLIGHT14, "Hello MonoGame \r http://www.xnadevelop.com", new Vector2(0, 160), Color.White);
            spriteBatch.DrawString(lindsey14, "Hello MonoGame \r http://www.xnadevelop.com", new Vector2(0, 200), Color.White);
            spriteBatch.DrawString(Pescadero14, "Hello MonoGame \r http://www.xnadevelop.com", new Vector2(0, 240), Color.White);
            spriteBatch.DrawString(PescaderoBold14, "Hello MonoGame \r http://www.xnadevelop.com", new Vector2(0, 280), Color.White);
            spriteBatch.DrawString(SegoeUIMono14, "Hello MonoGame \r http://www.xnadevelop.com", new Vector2(0, 320), Color.White);
            spriteBatch.DrawString(SegoeUIMonoBold14, "Hello MonoGame \r http://www.xnadevelop.com", new Vector2(0, 360), Color.White);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
