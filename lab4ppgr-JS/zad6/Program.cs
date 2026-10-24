Console.WriteLine("Imię?");
string imie = Console.ReadLine()!;

//

Console.WriteLine("HP? (1-100)");
bool HPcheck = int.TryParse(Console.ReadLine(), out int HP);
while ((!HPcheck) || (HP < 1) || (HP > 100))
{
    Console.WriteLine("HP? (1-100)");
    HPcheck = int.TryParse(Console.ReadLine(), out HP);
}

//

int HPMAX = 100;

//

Console.WriteLine("Złoto?");
bool Gcheck = int.TryParse(Console.ReadLine(), out int GOLD);
while ((!Gcheck) || (GOLD < 0))
{
    Console.WriteLine("Złoto?");
    Gcheck = int.TryParse(Console.ReadLine(), out GOLD);
}

//

Console.WriteLine("Liczba mikstur?");
bool MIXcheck = int.TryParse(Console.ReadLine(), out int MIX);
while ((!MIXcheck) || (MIX < 0))
{
    Console.WriteLine("Liczba mikstur?");
    MIXcheck = int.TryParse(Console.ReadLine(), out MIX);
}

//

int TURN = 1;
bool graDziala = true;
int wyprawy = 0;

//

while (graDziala)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("=== HELLO ADVENTURER ===");
    Console.WriteLine(imie);
    Console.WriteLine($"Tura: {TURN}");
    Console.Write($"HP: ");
    if (HP < 25)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    Console.Write($"{HP}/{HPMAX} ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write($"| Złoto: {GOLD} | Mikstury: {MIX}\n");

    Console.WriteLine("1 - Eksploruj loch");
    Console.WriteLine("2 - Użyj mikstury");
    Console.WriteLine("3 - Odpocznij");
    Console.WriteLine("4 - Pokaż statystyki");
    Console.WriteLine("5 - Zakończ grę");
    Console.ResetColor();

    int choice = int.Parse(Console.ReadLine()!);
    switch (choice)
    {
        case 1:
        wyprawy += 1;
        GOLD += 10;
        HP -= 8;
        if (HP <= 0)
            {
                graDziala = false;
            }
        else
            {
            Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine("\nPodczas wyprawy znalazłeś 10 złotych monet, ale straciłeś 8 HP!\n");
              TURN += 1;
              Console.ResetColor();
            }
        
        break;
        
        case 2:
        if (MIX > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nUżywasz mikstury! +20HP\n");
                HP += 20;
                MIX -= 1;
                Console.ResetColor();
                if (HP > 100)
                 {
                    HP = 100;
                 }
            }
        else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nBrak mikstur!\n");
                Console.ResetColor();
            }
        TURN += 1;
        break;

        case 3:

        if (GOLD >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nOdpoczywasz! +5HP, -3 Zlota\n");
                Console.ResetColor();
                 HP += 5;
                 GOLD -= 3;
                 if (HP > 100)
                 {
                    HP = 100;
                 }
                 TURN += 1;
            }
        else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nZa mało złota!\n");
                Console.ResetColor();
            }
        
        break;

        case 4:
        Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine($"\nTura: {TURN}");
        Console.Write($"HP: ");
         if (HP < 25)
         {
            Console.ForegroundColor = ConsoleColor.Yellow;
         }
         Console.Write($"{HP}/{HPMAX} ");
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.Write($"| Złoto: {GOLD} | Mikstury: {MIX}\n");
        Console.WriteLine($"Eksploracje: {wyprawy}\n");
        Console.ResetColor();
        break;

        case 5:
        graDziala = false;
        break;

        default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nBŁĄD: NIEZNANA AKCJA\n");
        Console.ResetColor();
        break;


    }


}

if (HP < 0)
{
    HP = 0;
}


if (HP <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\nPRZEGRANA! Umarłeś!\n");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nGra zakończona!\n");
}

    Console.WriteLine($"\nTury: {TURN}");
        Console.Write($"HP: ");
    Console.Write($"{HP}/{HPMAX} ");
    Console.Write($"| Złoto: {GOLD} | Mikstury: {MIX}");
        Console.WriteLine($"\nEksploracje: {wyprawy}\n");