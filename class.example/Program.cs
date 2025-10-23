using clas.example.Items;

internal class Program
{
    static void Main(string[] args)
    {
        Room[] rooms = new Room[]
            {
                new SingleRoom(101, 80),
                new DoubleRoom(202, 120),
            };


        Console.WriteLine("🏨 Welcome to Hotel Management System\n");

        Console.Write("How many days would you like to stay? ");
        int days = Convert.ToInt32(Console.ReadLine());

        foreach (var room in rooms)
        {
            Console.WriteLine(room.GetDescription());
            Console.WriteLine($"{days} nights stay cost: {room.CalculatePrice(days)}");
            Console.WriteLine();
        }
    }
}
