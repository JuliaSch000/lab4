Console.WriteLine("Podaj liczbę dni wyprawy (1-7):");

bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out int liczbaDni);
int zloto = 0;
int zdobycz = 0;
int fajnyDzien = 0;

if (!poprawnaLiczba || ((liczbaDni < 1) || (liczbaDni > 7)))
{
    Console.WriteLine("Zła liczba dni!!!!");
}
else
{
    for (int obecnyDzien = 1; obecnyDzien <= liczbaDni; obecnyDzien++)
    {
        Console.WriteLine($"Dzien {obecnyDzien}");
        Console.WriteLine($"Złoto: {zloto}");
        Console.WriteLine("Ile dzisiaj znalazłeś złota?");
        zdobycz = int.Parse(Console.ReadLine()!);
        zloto += zdobycz;
        if (zdobycz >= 10)
        {
            fajnyDzien++;
        }
        zdobycz = 0;

    }
    
Console.WriteLine("PODSUMOWANIE:");
Console.WriteLine($"Całość zdobytego złota: {zloto}");
Console.WriteLine($"Udane dni: {fajnyDzien}");
}

