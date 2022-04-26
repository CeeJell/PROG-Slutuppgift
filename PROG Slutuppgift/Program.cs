using PROG_Slutuppgift;

class Program
{

    public static void Main()
    {
        Console.WriteLine("Welcome to a Single User Dungeon, made by Charlie");

        Room room1 = new Room { Description = "" };
        Room room2 = new Room { Description = "" };
        Room room3 = new Room { Description = "" };


        Room currentRoom = room1;
        


        // Gameloop
        while (true)
        {
            Console.WriteLine("Where do you want to go? (N)orth, (S)outh, (E)ast or (W)est");
            var keyPressed = Console.ReadKey(true);

            Room tmpRoom = null;    
            switch (keyPressed.Key)
            {
                case ConsoleKey.N:
                    tmpRoom = currentRoom.GoNorth;
                    break;
                case ConsoleKey.S:
                    tmpRoom = currentRoom.GoSouth;
                    break;
                case ConsoleKey.E:
                    tmpRoom = currentRoom.GoEast;
                    break;
                case ConsoleKey.W:
                    tmpRoom = currentRoom.GoWest;
                    break;
                default:
                    System.Console.Write("Not one of the options, ");
                    break;
            }

            if (tmpRoom == null)
            {
                System.Console.WriteLine("You can't go that way");
                System.Console.WriteLine();
                continue;
            }
            currentRoom = tmpRoom;
            Console.WriteLine(currentRoom.Description);


        }







    }





}