// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//методы обработки
//метод запроса данных пользователя
int SetSize(string message=" ")
{
    Console.WriteLine($" {message}: ");
    string size_mass=Console.ReadLine();
    int size=int.Parse(size_mass);
    return size;
}

//метод создания массива
int[] FillArray (int Size)
{
    int[] array=new int[Size];
    Random random =new Random();
    for(int i=0;i<Size;i++)
    {
        int minValue=100;
        int gmaxValue=999;
        array[i]=random.Next(minValue,maxValue);

    }
    return array;
}

//метод проверки четности
int VolumeChetNumber(int[] array)
{
    int count=0;

    for(int i=0;i<array.Length;i++)
    {
        if(array[i]%2==0)
        {
            count=count+1;
        }
    }
    return count;
}

//выполнение
int size=SetSize("Введите размер массива: ");
int[] array=FillArray(size);

Console.WriteLine("Созданный массив:");
Console.WriteLine(string.Join(" ",array));

Console.WriteLine($"Число четных номеров:{VolumeChetNumber(array)}");

