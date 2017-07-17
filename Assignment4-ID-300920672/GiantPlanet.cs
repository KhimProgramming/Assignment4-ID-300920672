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
        public bool HasMoons()
        {
            //return MoonCount > 0;

            bool hasMoons = MoonCount > 0;
            return hasMoons;

            //if (MoonCount > 0)
            //{
            //    Console.WriteLine();
            //}
            //return this.HasMoons();
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                Console.WriteLine();
            }
            return this.HasRings();
        }
    }
}