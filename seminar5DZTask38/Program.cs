//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

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

array = GetArray(size, min, max );

int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
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

int[] ChangeSign(int[]someArray)
{
    int index = 0;
    int maxindex = 0;
    int minindex = 0;
    while(index < someArray.Length-1)
    {
        if(someArray[index]>someArray[maxindex]) maxindex = index;
        if(someArray[index]<someArray[minindex]) minindex = index;
        index = index + 1;
    }
    int result = someArray[maxindex] - someArray[minindex];
 
    Console.WriteLine($"из них максимальное число: {someArray[maxindex]}");
    Console.WriteLine($"из них минимальное число: {someArray[minindex]}");
    Console.WriteLine($"разницу между максимальным и минимальным значением элементов массива: {result}");
    return someArray;          
}

PrintArray(array);
array = ChangeSign(array);
