//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();


int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int size = InputNumber("Введите размер массива");
int min = InputNumber("Введите минимальное значение в массиве");
int max = InputNumber("Введите максимальное значение в массиве");
int[] array = GetArray(size, min, max );

int[] GetArray(int size, int min, int max)
{
    int[] res = new int [size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(min, max+1);
    }
    return res;    
}

void PrintArray(int[] someArray)
{
  Console.Write("сгенерированный массив из случайных чисел [");
  for (int i = 0; i < someArray.Length - 1; i++)
  {
    Console.Write($"{someArray[i]}, ");
  }
  Console.WriteLine($"{someArray[someArray.Length - 1]}]");
}


int[] SumOfOdd(int[]someArray)
{         
    int oddPosition = 0;  
    int count = 1;
    for(int i = 0; i<= someArray.Length-1; i=i+1) 
    { 
        if(i%2!=0) oddPosition = oddPosition + someArray[i]; 
    }    
    count = count + 1;
    Console.WriteLine($"сумма элементов, стоящих на нечётных позициях: {oddPosition}");
    return someArray;           
}

array = GetArray(size, min, max );
PrintArray(array);
array = SumOfOdd(array);

