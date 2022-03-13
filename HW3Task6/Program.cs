// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.Write("]");
Console.WriteLine();
int positive_sum = 0;
int negativ_sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        positive_sum += array[i];
    else
        negativ_sum += array[i];    // сумма отрицательных чискл в массиве будет равна всегда 0 
}                                   //  т.к в массиве по условию задачи нет отрицательных чисел
Console.WriteLine("Сумма положительных чисел в массиве равна  " + positive_sum);
Console.WriteLine("Сумма отрицательных чисел в массиве равна  " + negativ_sum);



