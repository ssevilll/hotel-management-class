namespace clas.example.Items

{
    internal class DoubleRoom : Room
    {
        public DoubleRoom(int roomNumber, double basePrice)
            : base(roomNumber, basePrice) { }

        public override double CalculatePrice(int nights)
        {
            // 10% discount for stays longer than 3 nights
            double total = BasePrice * nights;
            if (nights > 3)
                total *= 0.9;
            return total;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " | Type: Double Room | Max 2 persons";
        }
    }
}
