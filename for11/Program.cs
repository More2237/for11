var n = int.Parse(Console.ReadLine());
double c = 0;

for (int i = n; i <= 2*n; i++)
{
    c += i * i ;
}
Console.WriteLine(c);