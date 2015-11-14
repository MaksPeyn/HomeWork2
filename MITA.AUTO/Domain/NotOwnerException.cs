using System;

namespace Domain
{
    public class NotOwnerException: Exception
    {
        public NotOwnerException(string model)
        {
            Console.WriteLine("У автомобиля " + model + " нет водителя\n");
        }
    }
}