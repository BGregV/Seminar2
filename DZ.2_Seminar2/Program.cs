Console.Write("Введите первое число:");
double pervoeChislo = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число:");
double vtoroeChislo = double.Parse(Console.ReadLine() ?? "0");
double kvadrat = Math.Pow(vtoroeChislo, 2);
double kvadrat2 = Math.Pow(pervoeChislo, 2);
if (pervoeChislo == kvadrat)
{
    Console.WriteLine("Первое число квадрат второго");
}
else if (vtoroeChislo == kvadrat2)
{
    Console.WriteLine("Второе число квадрат первого");
}
else
{
    Console.WriteLine("Первое число не квадрат второго");
}