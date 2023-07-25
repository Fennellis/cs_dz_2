Console.WriteLine("Задача 10");
Console.WriteLine("Вторая цифра трехзначного числа");
Console.WriteLine();
Console.WriteLine("Задача 13");
Console.WriteLine("Третья цифра заданного числа");
Console.WriteLine();
Console.WriteLine("Задача 15");
Console.WriteLine("Проверка выходного дня");
Console.WriteLine();
Console.Write("Введите номер задания: ");
int nubmer = Convert.ToInt32(Console.ReadLine());

switch (nubmer)
{
    case 10:
        Ex1();
        break;
    case 13:
        Ex2();
        break;
    case 15:
        Ex3();
        break;
    default:
        Console.WriteLine("Неверный номер задания");
        break;
}

void Ex1()
{
    Start1:
    Console.Write("Введите трехзначное число : ");
    int num = Convert.ToInt32(Console.ReadLine());
    int a;
    if (num < 0) a = -num;
    else a = num;

    if (a < 100 || a >= 1000) 
    {
        Console.WriteLine("Число не трёхзначное. Попробуйте еще раз.");
        goto Start1;
    }

    int secondDigit = a / 10 % 10;
    Console.WriteLine($"Вторая цифра числа {num} => {secondDigit}");
}

void Ex2()
{
    Start2:
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    int a;
    if (num < 0) a = -num;
    else a = num;

    if (a < 100)
    {
        Console.WriteLine("Третьей цифры нет. Попробуйте еще раз.");
        goto Start2;
    }

    while (a > 999) a /= 10;

    int thirdDigit = a % 10;
    Console.WriteLine($"Третья цифра числа {num} => {thirdDigit}");
}

void Ex3()
{
    Start3:
    Console.Write("Введите номер дня недели: ");
    int day = Convert.ToInt32(Console.ReadLine());
    
    if (day < 1 || day > 8)
    {
        Console.WriteLine("Число не соответствует дню недели. Попробуйте еще раз");
        goto Start3;
    }

    if (day <= 5) Console.WriteLine("Нет");
    else Console.WriteLine("Да");
}

