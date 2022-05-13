using PROG_Slutuppgift;

class Program
{
    static int Score = 0;
    static int UserDMG = 3;
    static int UserHP = 20;
    static int MaxHP = 20;

    static int EnemyDMG = 2;
    static int EnemyHP = 18;

    static int BossDMG = 8;
    static int BossHP = 100;

    static int AppleCount = 0;

    static bool Fled = false;
    public static void Main()
    {
        Console.WriteLine("Welcome to a Single User Dungeon, made by Charlie");

        Room room1 = new Room { Description = "room 1" };
        Room room2 = new Room { Description = "room 2" };
        Room room3 = new Room { Description = "room 3" };

        Room lastRoom = room1;
        Room currentRoom = room1;
        Room tmpRoom = null;

        room1.loot = new Gold();

        room1.AddToNorth(room2);

        Console.WriteLine("Press 'Y' to see all Commands // Press 'I' to see your Inventory");
        Console.WriteLine("Where do you want to go? (N)orth, (S)outh, (E)ast or (W)est");

        // Gameloop
        while (true)
        {
            if (Fled)
            {
                tmpRoom = currentRoom;
                currentRoom = lastRoom;
                lastRoom = tmpRoom;
            }

            var keyPressed = Console.ReadKey(true);

            tmpRoom = null;    
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
                    Console.WriteLine("N: North / S: South / E: East / W: West");
                    Console.WriteLine("I: Inventory/Character Info / A: Eat Apple / D: Damage Opponent / F: Flee from Opponent");
                    continue;
                case ConsoleKey.I:
                    if (AppleCount != 0)
                    Console.WriteLine($"Apples: {AppleCount}");
                    Console.WriteLine($"Health: {UserHP}/{MaxHP}");
                    Console.WriteLine($"Attack Damage: {UserDMG}");
                    Console.WriteLine($"Score: {Score}");
                    continue;
                case ConsoleKey.A:
                    if (AppleCount == 0)
                        Console.WriteLine("You're out of apples.");
                    else
                    { 
                    AppleCount--;
                    UserHP += 5;
                    if (UserHP > MaxHP)
                        UserHP = 20;
                    }
                    continue;
                case ConsoleKey.R:
                    tmpRoom = currentRoom;
                    currentRoom = lastRoom;
                    lastRoom = tmpRoom;
                    Console.WriteLine("You fled to the latest room.");
                    continue;
                case ConsoleKey.D:
                    Console.WriteLine("no opponent to damage.");
                    continue;
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
            lastRoom = currentRoom;
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
            SwordFound();
        }
        if (room.loot is Helmet)
        {
            HelmetFound();
        }
        if (room.loot is Apple)
        {
            AppleFound();
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
    public static void EnemyFound()
    {
        Console.WriteLine("You encountered a Rat!");
        while (UserHP > 0 && EnemyHP > 0)
        {
            Console.WriteLine("Do you want to Attack (D), Flee (F) or Eat an Apple (A)?");

            var keyPressed = Console.ReadKey(true);
            switch (keyPressed.Key)
            {
                case ConsoleKey.Y:
                    Console.WriteLine("N: North / S: South / E: East / W: West");
                    Console.WriteLine("I: Inventory/Character Info / A: Eat Apple / D: Damage Opponent / F: Flee from Opponent");
                    continue;
                case ConsoleKey.I:
                    if (AppleCount != 0)
                        Console.WriteLine($"Apples: {AppleCount}");
                    Console.WriteLine($"Health: {UserHP}/{MaxHP}");
                    Console.WriteLine($"Attack Damage: {UserDMG}");
                    Console.WriteLine($"Score: {Score}");
                    continue;
                case ConsoleKey.A:
                    if (AppleCount == 0)
                        Console.WriteLine("You're out of apples.");
                    else
                    {
                        AppleCount--;
                        UserHP += 5;
                        if (UserHP > MaxHP)
                            UserHP = 20;

                    }
                    continue;
                case ConsoleKey.R:

                    Console.WriteLine("You fled to the latest room.");
                    continue;
                case ConsoleKey.D:
                    Console.WriteLine("no opponent to damage.");
                    continue;
                default:
                    System.Console.Write("Not one of the options, ");
                    break;
            }
        }
    }
}