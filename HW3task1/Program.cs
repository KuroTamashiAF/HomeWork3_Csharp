//Найти кубы чисел от 1 до N
Console.WriteLine("Введите число:  ");
long N = long.Parse(Console.ReadLine());
long Result;
Console.WriteLine("Кубы чисел от 1 до N   ");
for(int j = 0;j<=N;j++)
{
    Result = j*j*j;
    Console.Write(Result+ "  ");
}

