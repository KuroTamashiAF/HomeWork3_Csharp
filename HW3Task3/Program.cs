// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 3; i >= 0; i--)
{
    sum += x / (int)Math.Pow(10.0, i);
    x = x % (int)Math.Pow(10.0, i);
}
Console.WriteLine("Сумма цифр в числе равна " + sum);
//СОВМЕСТНО МОЕ РЕШЕНИЕ И ЧАСТИЧНО ИЗ ИНТЕРНЕТА, 
//ДОДУМАЛСЯ ДО ДЕЛЕНИЯ И ОСТАТКА ОТ ДЕЛЕНИЯ САМ, А ВОТ СТЕПЕНИ ПОДСМОТРЕЛ В ИНЕТЕ
// НУ И ТАК ЖЕ ПРОБЛЕМА В ТОМ,ЧТО НУЖНО ВРУЧНУЮ МЕНЯТЬ ЗНАЧЕНИЕ 
// i В ЗАВИСИМОСТИ ОТ КОЛИЧЕСТВА ЦИФР В ВВЕДЕННОМ ЧИСЛЕ 
// ПО ПРИНЦИПУ i = кол.во цифр - 1 !!!
// пытался сделать через if x>10&& x<100
// пременная numofdigit = 1 или 
// x>100 && x<1000
// переменная numofdigit = 2
// но при (int i = numofdigit; i >= 0; i--) запутался с видимостью и не 
// видимостью переменных и компилятор выдавал ошибку. 
// видимость или не видимость переменных еще не проходили. 