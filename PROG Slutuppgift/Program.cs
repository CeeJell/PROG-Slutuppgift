using PROG_Slutuppgift;

class Program
{

    public static void Main()
    {
        Console.WriteLine("Welcome to a Single User Dungeon, made by Charlie");

        Room room1 = new Room { Description = "" };
        Room room2 = new Room { Description = "" };
        Room room3 = new Room { Description = "" };

        room1.loot = new Goldcoin();


        Room currentRoom = room1;
        room1.AddToNorth(room2);
        


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
                    CheckForLoot(currentRoom);
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

    private static void CheckForLoot(Room room)
    {
        if(room.loot != null)
        {
            Console.WriteLine("you found loot");

            room.loot = null;
        }
    }
}