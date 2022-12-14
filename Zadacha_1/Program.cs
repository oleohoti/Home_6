// задача 1 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.
int [,] CreateArray(int m, int n)// создали массив размерностью m*n
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)// вывели массив на экран
{
    int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j]<0) Console.Write($"{array[i,j]} \t");
            else Console.Write($" {array[i,j]} \t");
        }
        Console.WriteLine();
    }
}
int[] MaxMin(int[,] array, int[]info)// нашли максимальное число и его индекс, то же самое с минимальным, записали в info
{
    int max_i = 0;
    int min_i=0;
    int max_j= 0;
    int min_j=0;
    int max=array[max_i,max_j];
    int min =array[min_i,max_j];

    int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j]>max) {max=array[i,j]; max_i = i;max_j=j;}
            else if (array[i,j]<=min){min=array[i,j]; min_i = i;min_j=j;}
        }
    }
    info[0]=max;
    info[1]=max_i;
    info[2]=max_j;
    info[3]=min;
    info[4]=min_i;
    info[5]=min_j;
    return info;
}
void InputInfo(int []info)// выводим информацию с помощью массива info
{
    Console.WriteLine($"Максимальное значение этого массива равно:{info[0]} индекс строки: {info[1]} индекс столбца :{info[2]}");
    Console.WriteLine($"Минимальное значение этого массива равно:{info[3]} индекс строки: {info[4]} индекс столбца :{info[5]}");
}
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int [,]array=CreateArray(m,n);
PrintArray(array);
int []info0 =new int [6];
int[]info1=MaxMin(array,info0);
InputInfo(info1);
