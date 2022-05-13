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
    static bool Gameloop = true;
    static bool AddLoot = false;
    public static void Main()
    {
        Console.WriteLine("Welcome to a Single User Dungeon, made by Charlie");
        Console.WriteLine();

        Room room1 = new Room { Description = "room 1" };
        Room room2 = new Room { Description = "room " };
        Room room3 = new Room { Description = "room" };
        Room room4 = new Room { Description = "room" };
        Room room5 = new Room { Description = "room" };
        Room room6 = new Room { Description = "room" };
        Room room7 = new Room { Description = "room 7" };
        Room room8 = new Room { Description = "room" };
        Room room9 = new Room { Description = "room" };
        Room room10 = new Room { Description = "room" };
        Room room11 = new Room { Description = "room" };
        Room room12 = new Room { Description = "room" };
        Room room13 = new Room { Description = "room" };
        Room room14 = new Room { Description = "room" };
        Room room15 = new Room { Description = "room" };
        Room room16 = new Room { Description = "room" };
        Room room17 = new Room { Description = "room" };
        Room room18 = new Room { Description = "room" };
        Room room19 = new Room { Description = "room" };
        Room room20 = new Room { Description = "room" };
        Room room21 = new Room { Description = "room" };
        Room room22 = new Room { Description = "room" };
        Room room23 = new Room { Description = "room" };
        Room room24 = new Room { Description = "room" };
        Room room25 = new Room { Description = "room" };
        Room room26 = new Room { Description = "room" };
        Room room27 = new Room { Description = "room" };
        Room room28 = new Room { Description = "room" };
        Room room29 = new Room { Description = "room" };
        Room room30 = new Room { Description = "room" };


        Room lastRoom = room1;
        Room currentRoom = room1;
        Room tmpRoom = null;


        room2.loot = new Gold();
        room3.loot = new Sword();
        room4.loot = new Gold();
        room5.loot = new Enemy();
        room6.loot = new Enemy();
        room7.loot = new Apple();
        room9.loot = new Enemy();
        room10.loot = new TwoApples();
        room11.loot = new Enemy();
        room12.loot = new Gold();
        room13.loot = new Gold();
        room15.loot = new Boss();
        room16.loot = new TwoApples();
        room19.loot = new Enemy();
        room20.loot = new Sword();
        room21.loot = new Helmet();
        room22.loot = new Enemy();
        room23.loot = new GoldAndApple();
        room24.loot = new Enemy();
        room25.loot = new TwoApples();
        room26.loot = new Apple();
        room27.loot = new Enemy();
        room28.loot = new Gold();
        room29.loot = new Sword();


        room1.AddToSouth(room7, true);
        room2.AddToSouth(room8, true);
        room3.AddToSouth(room9, true);
        room3.AddToEast(room4);
        room4.AddToSouth(room10);
        room5.AddToSouth(room11);
        room5.AddToEast(room6);
        room6.AddToEast(room7);
        room7.AddToEast(room8);
        room8.AddToEast(room9);
        room9.AddToEast(room10);
        room11.AddToSouth(room18);
        room12.AddToNorth(room7, true);
        room12.AddToSouth(room20);
        room13.AddToNorth(room8, true);
        room13.AddToSouth(room21);
        room14.AddToNorth(room9);
        room14.AddToSouth(room22);
        room15.AddToWest(room30);
        room15.AddToEast(room16);
        room16.AddToEast(room17);
        room17.AddToEast(room18);
        room18.AddToEast(room19);
        room19.AddToEast(room20, true);
        room21.AddToSouth(room25);
        room22.AddToEast(room23);
        room22.AddToSouth(room26);
        room24.AddToSouth(room27);
        room24.AddToEast(room25);
        room26.AddToSouth(room29);
        room27.AddToEast(room28);
        room29.AddToWest(room28, true);



        Console.WriteLine("Press 'Y' to see all Commands // Press 'I' to see your Inventory");


        // Gameloop
        while (Gameloop)
        {
            if (AddLoot)
            {
                room2.loot = new Gold();
                room3.loot = new Sword();
                room4.loot = new Gold();
                room5.loot = new Enemy();
                room6.loot = new Enemy();
                room7.loot = new Apple();
                room9.loot = new Enemy();
                room10.loot = new TwoApples();
                room11.loot = new Enemy();
                room12.loot = new Gold();
                room13.loot = new Gold();
                room15.loot = new Boss();
                room16.loot = new TwoApples();
                room19.loot = new Enemy();
                room20.loot = new Sword();
                room21.loot = new Helmet();
                room22.loot = new Enemy();
                room23.loot = new GoldAndApple();
                room24.loot = new Enemy();
                room25.loot = new TwoApples();
                room26.loot = new Apple();
                room27.loot = new Enemy();
                room28.loot = new Gold();
                room29.loot = new Sword();
            }
            if (Fled)
            {
                tmpRoom = currentRoom;
                currentRoom = lastRoom;
                lastRoom = tmpRoom;
                Console.WriteLine(currentRoom.Description);
                Fled = false;
            }

            Console.WriteLine("Where do you want to go? (N)orth, (S)outh, (E)ast or (W)est");
            Console.WriteLine();

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
                    UserHP += 10;
                    if (UserHP > MaxHP)
                        UserHP = 20;
                        Console.WriteLine("You ate an Apple, +10 HP");
                        Console.WriteLine($"Apples: {AppleCount}");
                    }
                    continue;
                case ConsoleKey.F:
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
                System.Console.WriteLine("You can't go that way.");
                continue;
            }
            lastRoom = currentRoom;
            currentRoom = tmpRoom;
            Console.WriteLine(currentRoom.Description);
            Console.WriteLine();
            CheckForLoot(currentRoom);


        }





    }

    private static void CheckForLoot(Room room)
    {
        if(room.loot != null)
        {
            WhatLoot(room);
            if (!Fled)
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
        if (room.loot is TwoApples)
        {
            TwoApplesFound();
        }
        if (room.loot is GoldAndApple)
        {
            GoldAndAppleFound();
        }
        if (room.loot is Enemy)
        {
            EnemyFound();
        }
        if (room.loot is Boss)
        {
            
        }

    }

    public static void GoldFound()
    {
        Score += 20;
        Console.WriteLine("You found Gold! +20 Score");
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
    public static void TwoApplesFound()
    {
        AppleCount += 2;
        Console.WriteLine("You found two Apples.");
        Console.WriteLine($"Apples: {AppleCount}");
    }
    public static void GoldAndAppleFound()
    {
        AppleCount++;
        Console.WriteLine("You found an Apple AND some Gold! +20 Score");
        Console.WriteLine($"Apples: {AppleCount}");
        Score += 20;
        Console.WriteLine($"Total Score: {Score}");
    }
    public static void EnemyFound()
    {
        Console.WriteLine("You encountered a Rat!");
        EnemyHP = 18;


        while (UserHP > 0 && EnemyHP > 0 && Fled == false)
        {
            Console.WriteLine();
            Console.WriteLine($"User HP: {UserHP} // Rat HP: {EnemyHP}");
            Console.WriteLine("Do you want to Attack (D), Flee (F) or Eat an Apple (A)?");
            Console.WriteLine();

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
                        UserHP += 10;
                        if (UserHP > MaxHP)
                            UserHP = 20;
                        Console.WriteLine("You ate an Apple, +10 HP");
                        Console.WriteLine();
                        Console.WriteLine($"The Rat bit you and did {EnemyDMG}!");
                        UserHP -= EnemyDMG;
                    }
                    continue;
                case ConsoleKey.F:
                    Fled = true;
                    Console.WriteLine("You fled to the room before.");
                    continue;
                case ConsoleKey.D:
                    Console.WriteLine($"You swung your sword and did {UserDMG} Damage!");
                    EnemyHP -= UserDMG;
                    Console.WriteLine();
                    Console.WriteLine($"The Rat bit you and did {EnemyDMG} Damage!");
                    UserHP -= EnemyDMG;
                    continue;
                default:
                    System.Console.Write("Not one of the options.");
                    break;
            }
        }
        if (Fled) ;

        else if (UserHP > 0)
        {
            Console.WriteLine("You Defeated the Rat! +10 Score!");
            Score += 10;
            Console.WriteLine($"Total Score: {Score}");
            Console.WriteLine("The Rat dropped an Apple!");
            AppleCount++;
            Console.WriteLine($"Apples: {AppleCount}");
        }
        else
            Restart();
    }
    static void BossFound()
    {
        Console.WriteLine("You encountered a BOSS MUTANT RAT!");
        EnemyHP = 18;


        while (UserHP > 0 && EnemyHP > 0 && Fled == false)
        {
            Console.WriteLine();
            Console.WriteLine($"User HP: {UserHP} // BOSS HP: {BossHP}");
            Console.WriteLine("Do you want to Attack (D), Flee (F) or Eat an Apple (A)?");
            Console.WriteLine();

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
                        UserHP += 10;
                        if (UserHP > MaxHP)
                            UserHP = 20;
                        Console.WriteLine("You ate an Apple, +10 HP");
                        Console.WriteLine();
                        Console.WriteLine($"The BOSS bit you and did {BossDMG}!");
                        UserHP -= BossDMG;
                    }
                    continue;
                case ConsoleKey.F:
                    Fled = true;
                    Console.WriteLine("You fled to the room before.");
                    Console.WriteLine("Where do you want to go? (N)orth, (S)outh, (E)ast or (W)est");
                    continue;
                case ConsoleKey.D:
                    Console.WriteLine($"You swung your sword and did {UserDMG} Damage!");
                    BossHP -= UserDMG;
                    Console.WriteLine();
                    Console.WriteLine($"The BOSS bit you and did {BossDMG} Damage!");
                    UserHP -= BossDMG;
                    continue;
                default:
                    System.Console.Write("Not one of the options.");
                    break;
            }
        }
        if (Fled) ;

        else if (UserHP > 0)
        {
            Console.WriteLine("You Defeated the BOSS! +100 Score!");
            Score += 100;
            Console.WriteLine($"Total Score: {Score}");
            Console.WriteLine("skriv något om häx fan i slutet");
        }
        else
            Restart();
    
}


    static void Restart()
    {
        Console.WriteLine("you seem to have died.");
        Console.WriteLine("sad i guess lol");
        Console.WriteLine("Press Enter to Start over");
        Console.ReadLine();
        Score = 0;
        UserDMG = 3;
        UserHP = 20;
        MaxHP = 20;

        EnemyDMG = 2;
        EnemyHP = 18;

        BossDMG = 8;
        BossHP = 100;

        AppleCount = 0;

        Fled = false;
        Gameloop = true;
        AddLoot = true;

        Console.Clear();
        Console.WriteLine("DU MÅSTE LÄGGA HIT ALL LOOT SAMT START RUMMET");
    }

}