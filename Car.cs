using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car
    {
        #region Member
        #endregion

        #region Constructor
        //Standard Constructor
        public Car()
        {
        }
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        #endregion

        #region Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string Color { get; set; }
        #endregion

        #region Function
        public virtual void OutputCar()
        {
            if (String.IsNullOrEmpty(Color))
                Console.WriteLine(string.Format("Brand: {1,15}{0}Model: {2,15}{0}HorsePower: {3,7} PS{0}",Environment.NewLine, Brand, Model, HorsePower));
            else
                Console.WriteLine(string.Format("Brand: {1,15}{0}Model: {2,15}{0}HorsePower: {3,7} PS{0}Color: {4,15}", Environment.NewLine, Brand, Model, HorsePower, Color));
        }
        #endregion
    }
}
