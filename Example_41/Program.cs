// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
void PrintArray(int[]array)
{
    Console.WriteLine("Введенный массив полностью: ");
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
void Count(int[]array)
{
    int count=0;
    foreach (int item in array)
    {
        if(item>0) count++; 
    }
    Console.WriteLine($"пользователь ввел: {count} положительных чисел");
}
Console.WriteLine("Введите кол-во чисел");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int[M];
for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Введите {i+1}-е число: ");
    array[i]=Convert.ToInt32(Console.ReadLine());
}
PrintArray(array);
Count(array);
