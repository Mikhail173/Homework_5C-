//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Input the size of the array");
int size = Convert.ToInt32(Console.ReadLine());

int sum  = 0;
int[] array = GetArray(size);

int[] GetArray(int size)

{
    
    int[] array = new int[size];
    
    for (int i=0; i<size; i++)
    {   
        array[i]=new Random().Next(100,1000);
        int element = array[i];
        if (element % 2 == 0)
        {
            sum += 1;
        }
        
    }
    return array;
}
Console.WriteLine(String.Join(",",array));
Console.WriteLine($"Sum of even numbers: {sum}");