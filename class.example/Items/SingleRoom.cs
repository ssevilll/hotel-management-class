namespace clas.example.Items
{
    internal class SingleRoom : Room
{
    public SingleRoom(int roomNumber, double basePrice)
        : base(roomNumber, basePrice) { }

    public override double CalculatePrice(int nights)
    {
        return BasePrice * nights;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " | Type: Single Room | Max 1 person";
    }
}
}

