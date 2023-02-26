// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Inputint(string prompt)
{
    System.Console.WriteLine($"{prompt} >");
    return Convert.ToInt32(Console.ReadLine());
}

int sumNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number %10;
        number /= 10;
    }
    return sum;
}


int userNumber = Inputint("Введите число");
System.Console.WriteLine($"Сумма цифр числа {userNumber} равна {sumNumber(userNumber)}");