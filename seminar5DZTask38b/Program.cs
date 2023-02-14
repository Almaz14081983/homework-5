// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
double[] array = GetArray(size);
Console.WriteLine("сгенерированный массив из случайных чисел: [" + String.Join(", ", array) + "],");
Console.WriteLine($"разницу между максимальным и минимальным элементами массива: {ChangeSign(array)}.");

double[] GetArray(int size)
{
    double[] res = new double [size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().NextDouble() + new Random().Next(-100, 100);       
    }
    return res;    
}

double ChangeSign(double[] someArray)
{
    double maxindex = someArray[0];
    double minindex = someArray[0];
    foreach( var index in someArray)
    {
        if(maxindex < index) maxindex = index;
        if(minindex > index) minindex = index;      
    }
    var result = maxindex - minindex;
 
    Console.WriteLine($"из них максимальное число: {maxindex},");
    Console.WriteLine($"из них минимальное число: {minindex},");
    
    return result;          
}


