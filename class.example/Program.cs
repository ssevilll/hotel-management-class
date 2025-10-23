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

        bool breakfast = false;
        Console.WriteLine("🏨 Welcome to Hotel Management System");
        Console.WriteLine("For double rooms there is 10% discount for stays longer than 3 nights\n");

        Console.Write("How many nights would you like to stay? ");
        int days = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many people are staying? ");
        int people = Convert.ToInt32(Console.ReadLine());

        Console.Write("Would you like to include breakfast for an additional $15 per night? (yes/no): ");
        string breakfastInput = Console.ReadLine().Trim().ToLower();
        if (breakfastInput == "yes" || breakfastInput == "y")
        {
            breakfast = true;
        }


        switch (people)
        {
            case 1:
                Console.WriteLine("\n");
                Console.WriteLine("\nYou have selected a Single Room.\n");
                foreach (var room in rooms)
                {
                    if (room is not SingleRoom) continue;
                    Console.WriteLine(room.GetDescription());
                    Console.WriteLine($"{days} nights stay cost: {room.CalculatePrice(days,breakfast)}");
                    Console.WriteLine();
                }
                break;
            case 2:
                Console.WriteLine("\n");
                Console.WriteLine("\nYou have selected a Double Room.\n");
                foreach (var room in rooms)
                {
                    if (room is not DoubleRoom) continue;
                    Console.WriteLine(room.GetDescription());
                    Console.WriteLine($"{days} nights stay cost: {room.CalculatePrice(days,breakfast)}");
                    Console.WriteLine();
                }
                break;
            default:
                Console.WriteLine("\nSorry, we only have Single and Double rooms available.\n");
                return;
        }
    }
}
