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

namespace ProgrammingAssignment2
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        const int WINDOW_WIDTH = 800;
        const int WINDOW_HEIGHT = 600;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // STUDENTS: add your sprite variables here
        Texture2D cat;
        Texture2D H;
        Texture2D penguine;
        Texture2D shape;
        Texture2D water;

        // used to handle generating random values
        Random rand = new Random();
        const int CHANGE_DELAY_TIME = 1000;
        int elapsedTime = 0;

        // used to keep track of current sprite and location
        Texture2D currentSprite;
        Rectangle drawRectangle = new Rectangle();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
            graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;
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

            // STUDENTS: load the images here
            cat = Content.Load<Texture2D>("cat");
            H = Content.Load<Texture2D>("H");
            penguine = Content.Load<Texture2D>("penguine");
            shape = Content.Load<Texture2D>("shape");
            water = Content.Load<Texture2D>("water");

            // STUDENTS: set the currentSprite variable to one of your sprite variables
            currentSprite = cat;
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

            elapsedTime += gameTime.ElapsedGameTime.Milliseconds;
            if (elapsedTime > CHANGE_DELAY_TIME)
            {
                elapsedTime = 0;

                // STUDENTS: uncomment the code below and make it generate a random number between 0 and 4
                // using the rand field I provided
                int spriteNumber = rand.Next(0, 4);

                // sets current sprite
                // STUDENTS: uncomment the lines below and change sprite0, sprite1, sprite2, sprite 3, and sprite 4
                //      to the five different names of your sprite variables
                if (spriteNumber == 0)
                {
                    currentSprite = cat;
                }
                else if (spriteNumber == 1)
                {
                    currentSprite = H;
                }
                else if (spriteNumber == 2)
                {
                    currentSprite = penguine;
                }
                else if (spriteNumber == 3)
                {
                    currentSprite = shape;
                }
                else if (spriteNumber == 4)
                {
                    currentSprite = water;
                }

                // STUDENTS: uncomment the line below to set drawRectangle.X to a random number between 0 and the preferred backbuffer width - the width of the current sprite 
                // using the rand field I provided
                drawRectangle.X = rand.Next(0, WINDOW_WIDTH - currentSprite.Width);

                // STUDENTS: uncomment the line below to set drawRectangle.Y to a random number between 0 and the preferred backbuffer height - the height of the current sprite
                // using the rand field I provided
                drawRectangle.Y = rand.Next(0, WINDOW_HEIGHT - currentSprite.Height);

                // STUDENTS: set the drawRectangle.Width and drawRectangle.Height to match the width and height of currentSprite
                drawRectangle.Width = currentSprite.Width;
                drawRectangle.Height = currentSprite.Height;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // STUDENTS: draw current sprite here
            spriteBatch.Begin();
            board.draw(spriteBatch);
   
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
