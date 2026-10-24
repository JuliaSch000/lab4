/// I WIN. I DID IT. MERRY CHRISTMAS.
Console.WriteLine("Podaj wysokość choinki:");
bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out int wysokosc);
int spacje = 0;
int ileHash = 0;

if (poprawnaLiczba)
{
   
   for (int progres = 0; progres < wysokosc; progres++)
    {
        spacje = 0;
        spacje = wysokosc - progres;
        while (spacje > 0)
        {
            Console.Write(" ");
            spacje--;
        }
        
        ileHash = 0;
        ileHash = progres + progres + 1;
        while (ileHash >0)
        {
             Console.Write("#");
             ileHash--;
        }
     
        spacje = 0;
        spacje = wysokosc - progres;
        while (spacje > 0)
        {
            Console.Write(" ");
            spacje--;
        }
        Console.Write("\n");
    }
    
     spacje = 0;
        spacje = wysokosc;
        while (spacje > 0)
        {
            Console.Write(" ");
            spacje--;
        }
        
        ileHash = 1;
        while (ileHash >0)
        {
             Console.Write("#");
             ileHash--;
        }
     
        spacje = 0;
        spacje = wysokosc;
        while (spacje > 0)
        {
            Console.Write(" ");
            spacje--;
        }
        Console.Write("\n");
    
}
else
{
    Console.WriteLine(":,(");
}