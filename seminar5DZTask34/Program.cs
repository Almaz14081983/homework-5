//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}
int size = InputNumber("Введите размер массива");

int[] array = GetArray(size);

int[] GetArray(int size)
{
    int[] res = new int [size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;    
}
array = GetArray(size);

void PrintArray(int[] someArray)
{
    Console.Write("сгенерированный массив из случайных чисел [");
    for (int i = 0; i < someArray.Length - 1; i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.WriteLine($"{someArray[someArray.Length - 1]}],"); 
}

int[] NumberEven(int[]someArray)
{
    int count = 0;
    int numberOfEven = 0;
    int numberOfOdd = 0;
    for(int i = 0; i<= someArray.Length-1; i++) 
    { 
        if (someArray[i]%2==0) numberOfEven = numberOfEven +1 ;   
        if (someArray[i]%2!=0) numberOfOdd = numberOfOdd +1 ;     
    }
    count = count + 1;
    Console.WriteLine($"из них количество четных чисел: {numberOfEven},");
    Console.WriteLine($"а количество нечетных чисел: {numberOfOdd}.");
    return someArray;          
}

PrintArray(array);
array = NumberEven(array);


