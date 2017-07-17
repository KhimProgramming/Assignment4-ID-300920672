using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
