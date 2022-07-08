void Zadacha25()
{
    Random random = new Random();
    int number = random.Next(2, 6);
    int exponent = random.Next(2, 5);

    Console.WriteLine($"Число {number} в степени {exponent} равно {Power(number, exponent)}");
}

int Power(int number, int exponent)
{
    int result = 1;
    for (int i = 0; i < exponent; i++) // 0 1 2
    {
        result *= number;    
    }
    return result;
}

void Zadacha27()
{
    Random random = new Random();
    int number = random.Next(100, 100000);

    SumOfDigit(number);

}
void SumOfDigit(int number)
{
    int sum = 0;
    Console.Write("В числе " + number);
    while(number > 0)
    {
        sum += number%10;
        number /= 10;
    }
    Console.WriteLine(" сумма цифр равна: " + sum);
}

void Zadacha29()
{
    int size = 8;
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10,11);
    }
    PrintArray(array);

    for (int i = array.Length -1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array [j + 1]))
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    PrintArray(array);
}
void Zadacha31()
{
    int size = 8;
    int[] array = new int[size];
    FillArray(array, -5, 5);
    PrintArray(array);
  
    Console.WriteLine("Сумма положительных элементов массива: " + SumPositive(array));
    Console.WriteLine("Сумма отризцательных элементов массива: " + SumNegative(array));
}

int SumNegative(int[] array)
{
    int sumNegative = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
    }
    return sumNegative;
}

int SumPositive(int[] array)
{
    int sumPositive = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
    }
    return sumPositive;
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
void  PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}
Zadacha31();