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

        Console.Write("How many people are staying? ");
        int people = Convert.ToInt32(Console.ReadLine());



        switch (people)
        {
            case 1:
                Console.WriteLine("\nYou have selected a Single Room.\n");
                foreach (var room in rooms)
                {
                    if (room is not SingleRoom) continue;
                    Console.WriteLine(room.GetDescription());
                    Console.WriteLine($"{days} nights stay cost: {room.CalculatePrice(days)}");
                    Console.WriteLine();
                }
                break;
            case 2:

                Console.WriteLine("\nYou have selected a Double Room.\n");
                foreach (var room in rooms)
                {
                    if (room is not DoubleRoom) continue;
                    Console.WriteLine(room.GetDescription());
                    Console.WriteLine($"{days} nights stay cost: {room.CalculatePrice(days)}");
                    Console.WriteLine();
                }
                break;
            default:
                Console.WriteLine("\nSorry, we only have Single and Double rooms available.\n");
                return;
        }
    }
}
