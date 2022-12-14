// Задача 2 VERY HARD необязательная Имеется список чисел. Создайте список, в который попадают числа, описывающие максимальную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.

// Пример:

// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]

// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5]

// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5]
void PrintArray(int[]array)
{
    Console.WriteLine("Введенный массив полностью: ");
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
int [] SelectionSort(int[]array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]<array[minPosition])
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}
// int []Array(int size)
// {
//     int[]array=new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i]=new Random().Next(1,10);
//     }
//     return array;
// }
void Sequence(int []array)
{
    int i1=0;
    int count1=0;
    int count=0;
    for(int i=0;i<array.Length-1;i++)
    {
    if (array[i]+1==array[i+1]) {count++; Console.WriteLine(count);}
    else if (count>count1){ i1=i-count; count1=count;count=0;}
    }
    Console.WriteLine($"{array[i1]}...{array[i1+count1]}");
}
// Console.WriteLine("Введите кол-во элементов в списке");
// int size = Convert.ToInt32(Console.ReadLine());
int[]list = {1,2,3,4,16,17,20,21,22,23,24,25};
PrintArray(list);
int[]sortlist=SelectionSort(list);
PrintArray(sortlist);
Sequence(sortlist);