using System;

namespace Domain
{
    public class NotCategoryException: Exception
    {
        public NotCategoryException(string name, char category)
        {
            Console.WriteLine("У водителя " + name + " нет категории прав " + category + "\n");
        }
    }
}