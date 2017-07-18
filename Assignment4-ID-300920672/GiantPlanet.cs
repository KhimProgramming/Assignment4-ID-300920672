using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Khim Tang
 * Date: July 11, 2017
 * Description: This is the GiantPlanet class that extends the Planet abstract class
 * Version: 0.1 - Created GianPlanet class
 */

namespace Assignment4_ID_300920672
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private readonly string _type;




        // PUBLIC PROPERTIES

        // CONSTRUCTORS ---------------------------
        /// <summary>
        /// This is the main constructor for the GiantPlanet class.
        /// It takes 4 parameters - name  (string) - diameter(double) - mass (double) - type (string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        /// <summary>
        /// This is HasMoons method that will return true if the MoonCount property is 
        /// greater than zero
        /// </summary>
        /// <returns></returns>
        public bool HasMoons()
        {
            //return MoonCount > 0;    or this way works also

            bool hasMoons = MoonCount > 0;
            return hasMoons;            
        }
        /// <summary>
        /// This is HasRings method that will return true if the RingCount property is 
        /// greater than zero
        /// </summary>
        /// <returns></returns>
        public bool HasRings()
        {
            // return RingCount > 0;   or this way works also

            bool hasRings = RingCount > 0;
            return HasRings();
        }
    }
}