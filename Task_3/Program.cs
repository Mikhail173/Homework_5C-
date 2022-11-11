//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Input the size of the array");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size);

int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(-100,100);
    }
    return array;
}
Console.WriteLine(String.Join(",",array));

int max = array[0]; 
for (int i=0; i<size; i++)
    {
        if (array[i] > max)
        max = array[i];
    }

int min = array[0]; 
for (int i=0; i<size; i++)
    {
        if (array[i] < min)
        min = array[i];
    }    

Console.WriteLine($"The difference between max and min : {max - min}");