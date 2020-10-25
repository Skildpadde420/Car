using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate 2 new objects
            Car car1 = new Car("Audi", "A3", 125);
            Car car2 = new Car("VW", "Golf", 170);

            car2.Color = "Red";

            car1.OutputCar();
            car2.OutputCar();

            Console.ReadKey();
        }
    }
}
