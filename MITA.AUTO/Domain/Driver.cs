using System;
using System.Linq;

namespace Domain
{
    public class Driver
    {
        public Driver(string name, int licenceDate)
        {
            Name = name;
            LicenceDate = licenceDate;
        }
        public readonly int LicenceDate;
        public readonly string Name;

        public int Experience()
        {
            return 2015 - LicenceDate;
        }
        public string Category { get; set; }

        public void OwnCar(Car car)
        {
            if (Category.Any(t => t == car.Category)) Car = car;
            else throw new NotCategoryException(Name, car.Category);
        }

        public Car Car { get; private set; }
    }
}