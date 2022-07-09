/*
Напишите цикл, который принимает на вход два числа (А и В) 
и возводит число А в натуральную степень В
*/

int GetPow (int x, int y)
{
    int result = 1;
    for (int i = 0; i < y; i++)
    {
        result = result * x;
    }
    return result;
}

Console.WriteLine("Enter first number: ");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondNum = int.Parse(Console.ReadLine());

Console.WriteLine(GetPow(firstNum, secondNum));