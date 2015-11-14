using System;
using System.Drawing;

namespace Domain
{
    class Program
    {
        static void Main(){}
    }
    public class Car
    {
        public Car(string model, char category)
        {
            Model = model;
            Category = category;
            Color = Color.Blue;
            CarPassport = new CarPassport(this);
        }
        public readonly string Model;
        public Color Color { get; set; }
        public string CarNumber { get; private set; }
        public readonly char Category;
        public readonly CarPassport CarPassport;

        public void ChangeOwner(Driver owner, string carNumber)
        {
            try { owner.OwnCar(this); }
            catch { return; }
            CarPassport.Owner = owner;
            CarNumber = carNumber;
        }
    }
}