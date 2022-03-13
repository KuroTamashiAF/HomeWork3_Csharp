//Найти сумму чисел от 1 до А
Console.WriteLine("Введите число :  ");
int A = int.Parse(Console.ReadLine());
int Result = 0;
for (int j = 0; j <= A; j++)
{
    Result += j;
}
Console.WriteLine("Сумма чисел от 1 до А равна   " + Result);