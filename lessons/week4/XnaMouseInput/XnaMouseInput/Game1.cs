using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace XnaMouseInput
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        const int WINDOW_WIDTH = 800;
        const int WINDOW_HEIGHT = 600;

        // drawing support
        Texture2D currentCharacter;
        Rectangle drawRectangle;

        // random character support
        Random rand = new Random();
        List<Texture2D> characters = new List<Texture2D>();
        //Texture2D[] characters = new Texture2D[4];

        // click support
        ButtonState previousButtonState = ButtonState.Released;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // set resolution and make mouse visible
            graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
            graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;
            IsMouseVisible = true;
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

            // load character sprites
            characters.Add(Content.Load<Texture2D>("character0"));
            characters.Add(Content.Load<Texture2D>("character1"));
            characters.Add(Content.Load<Texture2D>("character2"));
            characters.Add(Content.Load<Texture2D>("character3"));

            // start character 0 in center of window
            currentCharacter = characters[0];
            drawRectangle = new Rectangle(WINDOW_WIDTH / 2 - currentCharacter.Width / 2,
                WINDOW_HEIGHT / 2 - currentCharacter.Height / 2,
                currentCharacter.Width, currentCharacter.Height);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // make character follow mouse
            MouseState mouse = Mouse.GetState();
            drawRectangle.X = mouse.X - drawRectangle.Width / 2;
            drawRectangle.Y = mouse.Y - drawRectangle.Height / 2;

            // clamp character in window
            if (drawRectangle.Left < 0)
            {
                drawRectangle.X = 0;
            }
            if (drawRectangle.Right > WINDOW_WIDTH)
            {
                drawRectangle.X = WINDOW_WIDTH - drawRectangle.Width;
            }
            if (drawRectangle.Top < 0)
            {
                drawRectangle.Y = 0;
            }
            if (drawRectangle.Bottom > WINDOW_HEIGHT)
            {
                drawRectangle.Y = WINDOW_HEIGHT - drawRectangle.Height;
            }

            // change character on left mouse click (NOT LEFT MOUSE PRESS!)
            if (mouse.LeftButton == ButtonState.Released &&
                previousButtonState == ButtonState.Pressed)
            {
                // change to random character
                currentCharacter = characters[rand.Next(4)];
                drawRectangle.Width = currentCharacter.Width;
                drawRectangle.Height = currentCharacter.Height;
            }
            previousButtonState = mouse.LeftButton;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // draw character
            spriteBatch.Begin();
            spriteBatch.Draw(currentCharacter, drawRectangle, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
