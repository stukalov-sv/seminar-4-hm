/*
Напишите программу, которая задает массив из 8 элементов
и выводит их на экран
*/

int [] GetArray8(int[] array)
{
    Random randomNumber = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumber.Next(-100, 100);
    }
    return array;
}

int[] array = new int[8];
GetArray8(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}