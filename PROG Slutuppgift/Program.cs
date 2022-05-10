using PROG_Slutuppgift;

class Program
{
    static int Score = 0;
    static int UserDamage;
    static int UserHealth;
    public static void Main()
    {
        Console.WriteLine("Welcome to a Single User Dungeon, made by Charlie");

        Room room1 = new Room { Description = "room 1" };
        Room room2 = new Room { Description = "room 2" };
        Room room3 = new Room { Description = "room 3" };

        room1.loot = new Gold();


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
            WhatLoot(room);
            room.loot = null;
        }
    }

    public static void WhatLoot(Room room)
    {
        if(room.loot is Gold)
        {
            GoldFound();
        }
        if (room.loot is )
        {
            
        }
    }

    public static void GoldFound()
    {
        Score += 10;
        Console.WriteLine("You found Gold! +10 Score");
        Console.WriteLine($"Total Score: {Score}");
    }

}