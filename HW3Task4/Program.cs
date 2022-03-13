// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число до которого будем умножать:  ");
int num = int.Parse(Console.ReadLine());
int Product=1;
for(int j=1;j<=num;j++)
{
    Product*=j;
}
Console.WriteLine("произведение чисел от 1 до N равно:   "+ Product);
