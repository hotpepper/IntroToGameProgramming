using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DieExample
{
    /// <summary>
    /// A die
    /// </summary>
    class Die
    {
        #region Fields

        int numSides; //privat eby default
        int topSide;//hiden but stores state
        Random rand = new Random();

        #endregion

        #region Constructors
        //constructor
        public Die():this(6)
        {
            //numSides = 6;
            //topSide = 1;
        }
        /// <summary>
        /// constructor with number of sides for die
        /// </summary>
        /// <param name="numSides">number of sides the die should have</param>
        public Die(int numSides)
        {
            this.numSides = numSides;
            topSide = 1;
        }


        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of sides
        /// </summary>
        public int NumSides//provides access to state 
        {
            get { return numSides; }
            //set { numSides = value; }  // sets the state 
        }

        /// <summary>
        /// Gets the top side
        /// </summary>
        public int TopSide
        {
            get { return topSide; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// rolls the die
        /// </summary>
        public void Roll() //access type return type[void means None] mthod name()
        {
            //Random rand = new Random(); //moved to deal with sucsesive rolls using same seed ie. sys clock timep
            topSide = rand.Next(1, numSides + 1);

        }
        #endregion

    }
}
