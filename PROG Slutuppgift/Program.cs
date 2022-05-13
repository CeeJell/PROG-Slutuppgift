using PROG_Slutuppgift;

class Program
{
    static int Score = 0;
    static int UserDMG = 3;
    static int UserHP = 20;

    static int EnemyDMG = 2;
    static int EnemyHP = 18;

    static int BossDMG = 8;
    static int BossHP = 100;

    static int AppleCount = 0;

    public static void Main()
    {
        Console.WriteLine("Welcome to a Single User Dungeon, made by Charlie");

        Room room1 = new Room { Description = "room 1" };
        Room room2 = new Room { Description = "room 2" };
        Room room3 = new Room { Description = "room 3" };

        room1.loot = new Gold();


        Room currentRoom = room1;
        room1.AddToNorth(room2);

        Console.WriteLine("Press 'Y' to see all Commands // Press 'I' to see your Inventory");
        Console.WriteLine("Where do you want to go? (N)orth, (S)outh, (E)ast or (W)est");

        // Gameloop
        while (true)
        {

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
                case ConsoleKey.Y:
                    Console.WriteLine("N: North / S: South / E: East / W: West / I: Inventory/Character Info / A: Eat Apple / O: Attack Opponent");
                    break;
                default:
                    System.Console.Write("Not one of the options, ");
                    break;
            }

            if (tmpRoom == null && keyPressed.Key != ConsoleKey.Y)
            {
                System.Console.WriteLine("You can't go that way");
                System.Console.WriteLine();
                continue;
            }
            currentRoom = tmpRoom;
            Console.WriteLine(currentRoom.Description);
            CheckForLoot(currentRoom);


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
        if (room.loot is Sword)
        {
            
        }

    }

    public static void GoldFound()
    {
        Score += 10;
        Console.WriteLine("You found Gold! +10 Score");
        Console.WriteLine($"Total Score: {Score}");
    }
    public static void SwordFound()
    {
        UserDMG += 2;
        Console.WriteLine("You found a Sword! +2 DMG");
    }
    public static void HelmetFound()
    {
        UserHP += 10;
        Console.WriteLine("You found a Helmet! +10 HP");
    }
    public static void AppleFound()
    {
        AppleCount++;
        Console.WriteLine("You found an Apple.");
        Console.WriteLine($"Apples: {AppleCount}");
    }
}