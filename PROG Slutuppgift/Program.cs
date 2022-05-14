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

    static Random CritRnd = new Random();
    static int CritInt;
    public static void Main()
    {

        Room room1 = new Room { Description = "'Should i really enter this Cave? At least i have my sword if anything hostile lives there.' (South)" };
        Room room2 = new Room { Description = "'Oooo the portal took me to some more Gold! But it closed behind me. The only way out seems to be that small opening to the south.'" };
        Room room3 = new Room { Description = "'A SWORD! do they really just combine and become better? how does that work? Oh well, I can go back to where that rat was " +
            "by going south.'" };
        Room room4 = new Room { Description = "'GOLD! I FOUND GOLD! I'm keeping that and selling it. Is this way just a circle? I can continue this way by going west.'" };
        Room room5 = new Room { Description = "'ANOTHER ONE? The cave also takes a turn here to the south.'" };
        Room room6 = new Room { Description = "'Rats seem to like this place. I can continue west if i get past it.'" };
        Room room7 = new Room { Description = "'OH NO! The entrance got blocked by falling rocks. I guess I have to venture further. Hmm, there's an apple just laying here, " +
            "I wonder if its edible. I can go east and west, but I wonder why there's a small opening to the south.'" };
        Room room8 = new Room { Description = "'This place might be emptier than I thought. Why are there so many small openings, both north and south. At least I can " +
            "continue east.'" };
        Room room9 = new Room { Description = "'That's a rat. I wonder if it's hostile. The cave also seems to continue both east and south. And another stupid opening " +
            "to the north'" };
        Room room10 = new Room { Description = "'Two more apples. How are they not rotten? The cave is also making a turn to the north.'" };
        Room room11 = new Room { Description = "'Seriously? Another one? I'm starting to regret going this way, maybe I should go back. Or continue south.'" };
        Room room12 = new Room { Description = "'I wonder if this place is an old Goldmine. The opening to the north goes to the beginning. " +
            "It seems to be big enough to fit through from this end.'" };
        Room room13 = new Room { Description = "'More gold. Nice. I recognise the room to the north, even though the hole is small, I think it's the only way.'" };
        Room room14 = new Room { Description = "'Empty. I think I hear another Rat to the south.'" };
        Room room15 = new Room { Description = "'HOLY CRAP THAT RAT IS ENORMOUS! Can I really take him on? He doesn't look too fast though, so I think I will have time " +
            "to eat inbetween hits.'" };
        Room room16 = new Room { Description = "'Two more apples. Why do I hear such loud breathing to the east?'" };
        Room room17 = new Room { Description = "'Why is there a door if I continue this way? It looks locked, but maybe I can break the lock using my sword.'" };
        Room room18 = new Room { Description = "'Finally. Some rest. I can go both east and west.'" };
        Room room19 = new Room { Description = "'Damnit, I thought I was done with y'all. I can see something glimmering behind it though.'" };
        Room room20 = new Room { Description = "'AAAH, I fell. Another sword! and it forges together with mine. no logic. But at least it's sharper. I can't go back " +
            "where I came, so I'm guessing I have to continue north, as it's the only way.'" };
        Room room21 = new Room { Description = "'A Helmet?! That could come in handy. The cave seems to continue north.'" };
        Room room22 = new Room { Description = "'Why could I not have like a bow or something so I didn't have to get close to these thimgs. The cave continues south but " +
            "why are there vines on the east wall?'" };
        Room room23 = new Room { Description = "'Ooooo, behind the vines was a small space with Gold and an Apple!. But I can't see anymore paths this way.'" };
        Room room24 = new Room { Description = "'I'm getting good at finding these guys. I think I can see something green-ish to the east.'" };
        Room room25 = new Room { Description = "'More apples! The only way seems to be north. I think I can see another sword up ahead.'" };
        Room room26 = new Room { Description = "'Why does this cave have so many apples? I can continue south, or go back because this seems endless.'" };
        Room room27 = new Room { Description = "'I knew I should've taken that goddamn portal. After I MASSACRE this rat I can continue north.'" };
        Room room28 = new Room { Description = "'What is it with this cave and having openings you can only go through from one side? At least there is some gold here. " +
            "I can't go back so I guess I'll continue west.'" };
        Room room29 = new Room { Description = "'Ooooo, another merging sword. But more importantly, to the east there's a PORTAL? 'To the start' it says. hmmmmmm. " +
            "There's also a way to the west but I'm uncertain wether I would be able to go both ways through it. Or I could just walk back the same way I came.'" };
        Room room30 = new Room { Description = "'I defeated the huge rat thing!' 'cONGRATULATIONS aDVENTURER.' 'As I continued into the next room I see an old woman.' " +
            "'iF yOU wANT tO mAKE iT oUT, yOU hAVE tO dRINK tHIS pOTION, bUT iT'S nOT fREE. yOU sHOULD hAVE jUST eNOUGH iF yOU vENTURED tHROUGH tHE eNTIRE cAVESYSTEM. " +
            "iF yOU aRE uNSURE iF yOU hAVE eNOUGH oR nOT, yOU cAN cHOOSE tO hEAD bACK, EAST, bUT iF yOU tHINK yOU hAVE eNOUGH, bUY tHE pOTION, WEST. yOUR cHOICE'" };
        Room room31 = new Room { Description = "" };


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
        room29.AddToEast(room2, true);
        room30.AddToWest(room31);


        Console.WriteLine("Welcome to a Single User Dungeon, made by Charlie");
        Console.WriteLine();
        Console.WriteLine("Press 'Y' to see all Commands // Press 'I' to see your Inventory");
        Console.WriteLine();
        Console.WriteLine(currentRoom.Description);
        Console.WriteLine();


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
                currentRoom = room1;
                lastRoom = room1;
                AddLoot = false;
            }
            if (Fled)
            {
                tmpRoom = currentRoom;
                currentRoom = lastRoom;
                lastRoom = tmpRoom;
                Console.WriteLine(currentRoom.Description);
                Fled = false;
            }
            if (currentRoom == room31)
            {
                if (Score == 9999)
                {
                    Console.WriteLine("'yOU hAVE eNOUGH. tHANK yOU fOR tHE vISIT!'");
                    Console.WriteLine("You drink the potion and your vision fades to black.");
                    Console.WriteLine("You wake up outside of the cave. The entrance isn't blocked anymore.");
                    Console.WriteLine("You check your pockets to find yourself emptyhanded apart from One Apple.");
                    Console.WriteLine("You debate wether or not you want to go back or not.");
                    Console.WriteLine("GOOD ENDING!");
                    Console.WriteLine("Press Enter to play again.");
                    Console.ReadLine();
                    Restart();
                }
                else
                {
                    Console.WriteLine("'i dON'T kNOW hOW tO sAY tHIS. yOU dON'T hAVE eNOUGH.");
                    Console.WriteLine("The old lady drinks the potion and fades away.");
                    Console.WriteLine("You hear the caves rumble as rocks begin to fall.");
                    Console.WriteLine("BONK");
                    Console.WriteLine("Right in your head. As your vision turns to black, you wonder why you ever went into this unknown cave.");
                    Console.WriteLine("bad ending.");
                    Console.WriteLine("Press Enter to play again.");
                    Console.ReadLine();
                    Restart();
                }
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
                    UserHP += 5;
                    if (UserHP > MaxHP)
                        UserHP = 20;
                        Console.WriteLine("You ate an Apple, +5 HP");
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
            if (currentRoom == room16)
            {
                if (UserDMG != 6)
                {
                    Console.WriteLine("'The lock wont budge, I guess I have to become stronger.'");
                    currentRoom = room17;
                    lastRoom = room18;
                    continue;
                }
            }
            Console.WriteLine(currentRoom.Description);
            Console.WriteLine();
            CheckForLoot(currentRoom);


            if (currentRoom == room7)
            {
                room7.Description = "'I'm back at the beginning. Should I go east or west?'";
            }
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
            BossFound();
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
        UserDMG += 1;
        Console.WriteLine("You found a Sword! +1 DMG");
    }
    public static void HelmetFound()
    {
        UserHP += 10;
        MaxHP += 10;
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
                        UserHP += 5;
                        if (UserHP > MaxHP)
                            UserHP = 20;
                        Console.WriteLine("You ate an Apple, +5 HP");
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
                    CritInt = CritRnd.Next(1, 11);
                    if (CritInt == 1)
                    {
                        Console.WriteLine($"You swung and got a CRITICAL HIT, {UserDMG * 2} Damage!");
                        EnemyHP -= 2 * UserDMG;
                    }
                    else
                    {
                        Console.WriteLine($"You swung your sword and did {UserDMG} Damage!");
                        EnemyHP -= UserDMG;
                    }
                    Console.WriteLine();
                    CritInt = CritRnd.Next(1, 11);
                    if (CritInt == 1)
                    {
                        Console.WriteLine($"The Rat bit you and got a CRITICAL HIT, {EnemyDMG * 2} Damage!");
                        UserHP -= 2 * EnemyDMG;
                    }
                    else
                    {
                        Console.WriteLine($"The Rat bit you and did {EnemyDMG} Damage!");
                        UserHP -= EnemyDMG;
                    }
                    continue;
                default:
                    System.Console.Write("Not one of the options.");
                    break;
            }
        }
        if (Fled) ;

        else if (UserHP > 0)
        {
            Console.WriteLine();
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
                        UserHP += 5;
                        if (UserHP > MaxHP)
                            UserHP = 20;
                        Console.WriteLine("You ate an Apple, +5 HP");
                        Console.WriteLine();
                    }
                    continue;
                case ConsoleKey.F:
                    Console.WriteLine("You tried to flee back but the BOSS didn't let you.");
                    continue;
                case ConsoleKey.D:
                    CritInt = CritRnd.Next(1, 11);
                    if (CritInt == 1)
                    {
                        Console.WriteLine($"You swung and got a CRITICAL HIT, {UserDMG * 2} Damage!");
                        BossHP -= 2 * UserDMG;
                    }
                    else
                    {
                        Console.WriteLine($"You swung your sword and did {UserDMG} Damage!");
                        BossHP -= UserDMG;
                    }
                    Console.WriteLine();
                    CritInt = CritRnd.Next(1, 11);
                    if (CritInt == 1)
                    {
                        Console.WriteLine($"The BOSS bit you and got a CRITICAL HIT, {EnemyDMG * 2} Damage!");
                        UserHP -= 2 * BossHP;
                    }
                    else
                    {
                        Console.WriteLine($"The Rat bit you and did {EnemyDMG} Damage!");
                        UserHP -= BossHP;
                    }
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
        if (UserHP !> 0)
        {
            Console.WriteLine("you seem to have died.");
            Console.WriteLine("sad i guess lol");
            Console.WriteLine("Press Enter to Start over");
            Console.ReadLine();
        }

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