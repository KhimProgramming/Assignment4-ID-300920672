using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Khim Tang
 * Date: July 17, 2017
 * Description: This is the driver/program class
 * Version: 0.1 - To use the GiantPlanet class by creating a new giantPlanet object
 */

namespace Assignment4_ID_300920672
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet jupiter = new GiantPlanet("Jupiter",123000,9952854284, "Gas");
            Console.WriteLine(  jupiter.ToString());

            Console.ReadKey();
        }
    }
}
