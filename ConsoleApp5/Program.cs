Console.WriteLine("Введите значение катета: ");
double a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение гипотенузы: ");
double c = int.Parse(Console.ReadLine());
double b = Math.Sqrt((c * c) - (a * a));
Console.WriteLine("Значение второго катета: " + b);
//6.114 индивидуальное задание:
//Дано целое число, не меньшее 2. Выведите его наименьший натуральный делитель, отличный от 1.
Console.WriteLine("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
while (i <= n)
{
    i = i + 1;
    if (n % i == 0)
    {
        Console.WriteLine("Его наименьший делитель: " + i);
        break;
    }
}
