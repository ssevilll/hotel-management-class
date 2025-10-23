namespace clas.example.Items
{
    internal abstract class Room
    {
    public int RoomNumber;
    public double BasePrice;

        public Room(int roomNumber, double basePrice)
        {
            RoomNumber = roomNumber;
            BasePrice = basePrice;
        }

        public abstract double CalculatePrice(int nights, bool breakfastIncluded);

        public virtual string GetDescription()
        {
            return $"Room #{RoomNumber} - Base price: {BasePrice}";
        }
    }
}

