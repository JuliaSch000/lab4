int numerRos = 1;

Console.WriteLine("Rosnąco:");
while (numerRos < 11)
{
    Console.Write($"{numerRos} ");
    numerRos++;
}

Console.WriteLine("");
int numerMal = 10;

Console.WriteLine("Malejąco:");
while (numerMal > 0)
{
    Console.Write($"{numerMal} ");
    numerMal--;
}

Console.WriteLine("");
int numerParz = 0;

Console.WriteLine("Parzyście:");
while (numerParz < 21)
{
    Console.Write($"{numerParz} ");
    numerParz += 2;
}

///
///

Console.WriteLine("");
Console.ReadLine();
Console.WriteLine("");

///
///


numerRos = 1;
Console.WriteLine("Rosnąco:");
do
{
    Console.Write($"{numerRos} ");
    numerRos++;
}

while (numerRos < 11);

Console.WriteLine("");
numerMal = 10;
Console.WriteLine("Malejąco:");
do
{
    Console.Write($"{numerMal} ");
    numerMal--;
}

while (numerMal > 0);

Console.WriteLine("");
numerParz = 0;
Console.WriteLine("Parzyście:");
do
{
    Console.Write($"{numerParz} ");
    numerParz += 2;
}

while (numerParz < 21);


///
///

Console.WriteLine("");
Console.ReadLine();
Console.WriteLine("");

/// 
/// 

numerRos = 1;
numerMal = 10;
numerParz = 0;

Console.WriteLine("Rosnąco:");
for (numerRos = 1; numerRos < 11; numerRos++)
{
    Console.Write($"{numerRos} ");
}

Console.WriteLine("");

Console.WriteLine("Malejąco:");
for (numerMal = 10; numerMal > 0; numerMal--)
{
    Console.Write($"{numerMal} ");
}

Console.WriteLine("");
Console.WriteLine("Parzyście:");

for (numerParz = 0; numerParz < 21; numerParz += 2)
{
    Console.Write($"{numerParz} ");
}

Console.WriteLine("");
Console.WriteLine("Start!");

