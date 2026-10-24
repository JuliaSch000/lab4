
bool trwa = true;
int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int liczbaMikstur = 2;
int numerTury = 1;
bool defaultResult = false;
bool escape = false;

while (trwa == true)
{
    Console.WriteLine($"TURA {numerTury}\n");
    Console.WriteLine($"1 - ATAK");
    Console.WriteLine($"2 - MIKSTURA");
    Console.WriteLine($"3 - UCIECZKA");
    numerTury++;

    int wybor = int.Parse(Console.ReadLine()!);

    switch (wybor)
        {
            case 1:
            Console.WriteLine($"Atakujesz przeciwnika!");
            zdrowiePrzeciwnika -= 12;
            if (zdrowiePrzeciwnika < 0)
            {
                Console.WriteLine($"WYGRYWASZ!!!");
                break;
            }

            else
            {
                Console.WriteLine($"Zostało mu {zdrowiePrzeciwnika} punktów życia!");
                break;
            }
            

            case 2:

            if (liczbaMikstur > 0)
            {
                Console.WriteLine($"Używasz mikstury!");
                zdrowieBohatera += 15;
                liczbaMikstur --;
                Console.WriteLine($"Masz teraz {zdrowieBohatera} punktów życia!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"Brak mikstur!");
                break;
            }
             break;

            case 3:

            Console.WriteLine($"Ucieczka się powiodła!");
            escape = true;
            trwa = false;
            break;

            default:
            defaultResult = true;
            continue;

         

        }
   
   Console.WriteLine("");

   if ((zdrowiePrzeciwnika < 0) || escape)
    {
        trwa = false;
        break;
    }
    else if (defaultResult)
    {
       continue;
    }
    else
    {
         Console.WriteLine($"Przeciwnik atakuje!");
        zdrowieBohatera -= 7;
            if (zdrowieBohatera < 0)
            {
                Console.WriteLine($"PRZEGRYWASZ!!!");
                break;
            }

            else
            {
                Console.WriteLine($"Zostało ci {zdrowieBohatera} punktów życia!");
                Console.WriteLine("");
            }
            continue;

    
    }
   

    


}

Console.WriteLine($"KONIEC WALKI.");