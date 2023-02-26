// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputInt(string prompt)
{
    System.Console.Write($"{prompt} >");
    return Convert.ToInt32(Console.ReadLine());
}
int Power(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}
int numberA = InputInt("Введите число A");
int numberB = InputInt("Введите число B");
System.Console.WriteLine($"Число {numberA} в степени {numberB} = {Power(numberA, numberB)} ");
