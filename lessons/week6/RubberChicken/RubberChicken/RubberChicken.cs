using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input; ///get mouse state

namespace RubberChicken
{
    /// <summary>
    /// A rubber chicken
    /// </summary>
    class RubberChicken
    {
        #region Fields

        bool active = true;
        int damage;

        // drawing and moving support
        Texture2D sprite;
        Rectangle drawRectangle;

        //MOVING SUPPORT
        Vector2 velocity = Vector2.Zero;
        const int RUBBER_CHICKEN_SPEED = 5;

        //click processing
        bool clickStarted = false;
        bool buttonReleased = true;
        bool moving = false;

        #endregion
        
        #region Constructors
        
        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="sprite">sprite</param>
        /// <param name="location">location of center (vector2)</param>
        /// <param name="damage">damage from rubber chicken</param>
        public RubberChicken(Texture2D sprite, Vector2 location,
            int damage)
        {
            this.sprite = sprite;
            this.damage = damage;

            //build draw rectablge 
            drawRectangle = new Rectangle(
                (int)(location.X - sprite.Width / 2),
                (int)(location.Y - sprite.Height / 2),
                sprite.Width,
                sprite.Height);

        }
           

        #endregion
        
        #region Properties

        /// <summary>
        /// Gets and sets whether the rubber chicken is active
        /// </summary>
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        /// <summary>
        /// Gets the collision rectangle for the rubber chicken
        /// </summary>
        public Rectangle CollisionRectangle
        {
            get { return drawRectangle; }
        }

        /// <summary>
        /// Gets the damage the rubber chicken inflicts
        /// </summary>
        public int Damage
        {
            get { return damage; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// updat echickewn
        /// moving and launching when cliucked
        /// </summary>
        /// <param name="gameTime">game time, current </param>
        /// <param name="mouse">mouse state</param>
        public void Update(GameTime gameTime, MouseState mouse)
        {
        
            //move based on velocity
            drawRectangle.X += (int)(velocity.X * gameTime.ElapsedGameTime.Milliseconds);
            drawRectangle.Y += (int)(velocity.Y * gameTime.ElapsedGameTime.Milliseconds);

            //launch on click
            // check for mouse over button
            if (drawRectangle.Contains(mouse.X, mouse.Y))
            {

                // check for click started on chicken
                if (mouse.LeftButton == ButtonState.Pressed &&
                    buttonReleased)
                {
                    clickStarted = true;
                    buttonReleased = false;
                }
                else if (mouse.LeftButton == ButtonState.Released)
                {
                    buttonReleased = true;

                    // if click finished on chicken, change game state
                    if (clickStarted)
                    {
                        //launch chicken
                        if (!moving)
                        {
                            moving = true;
                            velocity = new Vector2(0, -1* RUBBER_CHICKEN_SPEED);
                        }
                        clickStarted = false;
                    }
                }
            }
            else
            {
                

                // no clicking on this button
                clickStarted = false;
                buttonReleased = false;
            }
 

        }


        /// <summary>
        /// draws ruber chicken
        /// </summary>
        /// <param name="spriteBatch">spriteBatch</param>
        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, drawRectangle, Color.White);
        }
        
        #endregion
    }
}
