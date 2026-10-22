/// will finish at home becayse this is Evil
Console.WriteLine("Podaj wysokość choinki:");
bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out int wysokosc);
int szerokoscStala = wysokosc - 1;
int ileSpacji = 0;
int ileHash = 0;

if (poprawnaLiczba)
{
    for (int progres = 0; progres <= wysokosc; progres++)
    {
        ileSpacji = szerokoscStala - progres;
        while (ileSpacji > 0)
        {
          Console.Write(" ");
          ileHash = wysokosc - ileSpacji;
          while (ileHash > 0)
            {
                Console.Write("#");
                ileHash--;
            }
            ileHash = 0;
          ileSpacji--;
          

        }
        
        Console.Write("#\n");
        
    }
    
}
else
{
    Console.WriteLine(":,(");
}