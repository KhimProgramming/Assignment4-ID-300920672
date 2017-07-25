using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Khim Tang
 * Date: July 17, 2017
 * Description: This is the driver/program class
 * Version: 0. 2- To use the TerrestrialPlanet class by creating a new TerrestrialPlanet object
 */

namespace Assignment4_ID_300920672
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet jupiter = new GiantPlanet("Jupiter", 123000, 9952854284, "Gas");
            //Writing jupiter without ToString() will work the same as using it.
            Console.WriteLine(jupiter.ToString());
            // Console.WriteLine(jupiter);

            TerrestrialPlanet mercury = new TerrestrialPlanet("Mercury", 2333333, 900000000, true);
            // Console.WriteLine(mercury);
            Console.WriteLine(mercury.ToString());
            Console.ReadKey();


        }
    }
}
