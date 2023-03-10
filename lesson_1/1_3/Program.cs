Console.WriteLine("Ввведите число N =");
int n = int.Parse(Console.ReadLine()!);

if (n < 0)
{
    n = -n;
}

int count = -n;
while (count != n)
{
    Console.WriteLine(count);
    if (n < 0)
    {
        count--;
    }
else
{
    count++;
}
}


