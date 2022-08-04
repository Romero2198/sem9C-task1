Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    int max = m,
        min = n;
    if (max < min)
    {
        max = n;
        min = m;
    }
    if (min == max)
        return min;
    else
    {
        Console.Write(NaturalNumber(max - 1, min) + ", ");
        return max;
    }
}
