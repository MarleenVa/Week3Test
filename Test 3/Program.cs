Console.WriteLine("Sisestage oma hinne (A, B, C, D või F):");
char hinne = Char.ToUpper(Console.ReadKey().KeyChar);
Console.WriteLine();

if (hinne == 'A')
{
    Console.WriteLine("Suurepärane!");
}
else if (hinne == 'B')
{
    Console.WriteLine("Väga hea! ");
}
else if (hinne == 'C')
{
    Console.WriteLine("Hea!");
}
else if (hinne == 'D')
{
    Console.WriteLine("Rahuldav! ");
}
else if (hinne == 'F')
{
    Console.WriteLine("Kahjuks ebaõnnestusite.");
}
else
{
    Console.WriteLine("Vale väärtus.");
}