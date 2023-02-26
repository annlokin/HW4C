// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] FillArray(int size)
{
    int [] userArray = new int [size];
    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = new Random().Next(0, 100);
    }
    return userArray;
}

void PrintArray(int[] array) //
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}

int InputSizeArray(string msg)
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32 (Console.ReadLine());
}
int sizeArray = InputSizeArray("Введите размер массива");
int[] userArray = FillArray(sizeArray);
PrintArray(userArray);
