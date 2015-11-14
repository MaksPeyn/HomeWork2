using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Автошкола
{
    class Program
    {
        static void Main()
        {
            var car = new Car("Лада", 'D') { Color = Color.DarkViolet };
            try
            {
                Console.WriteLine(car.CarPassport.Owner.Name);
            }
            catch
            {
                // ignored
            }
            var driver = new Driver("Вольдемар", 2002) { Category = "BC" };
            car.ChangeOwner(driver, "о777оо");
            driver.Category += 'D';
            car.ChangeOwner(driver, "о777оо");
            Console.WriteLine(driver.Car.CarNumber);
            Console.WriteLine(car.CarPassport.Owner.Name);
            Console.ReadKey();
        }
    }
}
