namespace Domain
{
    public class CarPassport
    {
        private Driver _owner;
        public CarPassport(Car car)
        {
            Car = car;
        }
        public Driver Owner
        {
            get
            {
                if(_owner == null) throw new NotOwnerException(Car.Model);
                return _owner;
            }
            set { _owner = value; }
        }
        public readonly Car Car;
    }
}