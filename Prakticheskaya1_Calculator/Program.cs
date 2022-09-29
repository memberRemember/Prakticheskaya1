

Console.WriteLine("Выберите какую операцию вы хотите выполнить:");
Console.WriteLine("1. Сложить два числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1% числа");
Console.WriteLine("8. Найти факториал числа");
Console.WriteLine("9. Завершить программу");


bool negrPashet = true;
do
{
    int operationNum;
    int a, b, n;
    Console.Write("Введите номер операции: ");
    operationNum = Convert.ToInt32(Console.ReadLine());

    if (operationNum == 9)
    {
        negrPashet = false;
    }
    if (operationNum == 1)
    {
        Console.Write("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ответ: ");
        Console.WriteLine(a + b);
    }
    if (operationNum == 2)
    {
        Console.Write("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ответ: ");
        Console.WriteLine(b - a);

    }
    if (operationNum == 3)
    {
        Console.Write("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ответ: ");
        Console.WriteLine(a * b);
    }
    if (operationNum == 4)
    {
        Console.Write("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ответ: ");
        Console.WriteLine(a / b);
    }
    if (operationNum == 5)
    {
        Console.Write("Введите число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите степень, в которую возвети число " + a + ": ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ответ: " + Math.Pow(a, n));
    }
    if (operationNum == 6)
    {
        Console.Write("Введите число, из которого найти квадратный корень: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ответ: " + Math.Sqrt(a));
    }
    if (operationNum == 7)
    {
        Console.Write("Введите число, 1% которого надо найти: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ответ: " + (a / 100));
    }
    if (operationNum == 8)
    {
        Console.Write("Введите число, факториал которого надо найти: ");
        a = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= a; i++)
        {
            factorial *= i;
        }
        Console.Write("Ответ: " + factorial);
    }

}
while (negrPashet == true);
{
    Console.WriteLine("Завершение программы...");
}

