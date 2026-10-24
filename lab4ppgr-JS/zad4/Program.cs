bool succeeded = false;
int liczbaTur = 0;

while (succeeded == false)
{
Console.WriteLine("Podaj liczbę tur od 1 do 10:");
bool poprawnyFormat = int.TryParse(Console.ReadLine(), out liczbaTur);

    if (!poprawnyFormat)
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
        continue;
    }

    if (liczbaTur < 1 || liczbaTur > 10)
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
        continue;
    }

    break;
}

Console.WriteLine($"Rozpoczynam grę na {liczbaTur} tur.");