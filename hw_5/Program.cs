/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

void Zadacha34()
{
    Random random = new Random();
    int size = random.Next(4,6);
    int[] array = new int[size];
     
      
    FillArray(array, 100,999);
    PrintArray(array);
    Console.WriteLine($"В массиве четных элементов: {AmountOfEven(array)}");
    
    
}

int AmountOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            count += 1;
        } 
    }
    return count; 
}
void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}
void FillArray(int[] array, int statNumber, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(statNumber, finishNumber);
    }

}

/*  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
void Zadacha36()
{
    Random random = new Random();
    int size = random.Next(4,6);
    int[] array = new int[size];
     
      
    FillArray(array, 1,20);
    PrintArray(array);
    Console.WriteLine($"Сумма нечетных элементов: {SummOfOdd(array)}");
    
    
}

int SummOfOdd(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2!=0)
        {
            summ += array[i];
        } 
    }
    return summ; 
}

/*  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

void Zadacha38()
{
    Random random = new Random();
    int size = random.Next(4,6);
    double[] array = new double[size];
     
      
    FillArrayDouble(array, 1,20);
    PrintArrayDouble(array);
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {string.Format("{0:F2}", Diff(array))}");
        
}

double Diff(double[] array)
{
    double diff=0;
    for (int i = 0; i < array.Length; i++)
    {
       diff = array[array.Length-1]-array[0];
    }
    return diff;
}
void PrintArrayDouble(double[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(string.Format("{0:F2}", array[i]) + "\t");
    }
    Console.WriteLine();
}
void FillArrayDouble(double[] array, int statNumber, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(statNumber, finishNumber) + random.NextDouble();
    }

}
Zadacha38();

void Test()
{
    double[,] a = new double[5, 10];

    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
            Console.Write("{0,6:F2}", a[i, j]);
        }
        Console.WriteLine();
    }
}
