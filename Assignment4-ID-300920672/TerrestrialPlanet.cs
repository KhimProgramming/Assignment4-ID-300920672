using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Khim Tang
 * Date: July 13, 2017
 * Description: This is the TerrestrialPlanet class that extends the Planet abstract class
 * Version: 0.1 - Created TerrestrialPlanet class
 */

namespace Assignment4_ID_300920672
{
    public class TerrestrialPlanet : Planet,IHasMoons,IHasRings
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private bool _oxygen;

        // PROPERTIES
      
    }
    public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) :base(name, diameter, mass)
    {
        this._oxygen = oxygen;
    }
}