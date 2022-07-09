/*
Напишите программу, которая принимает на вход число
и выдает сумму цифр в числе
*/

int GetNumberSumm(int x)
{
    string str = Convert.ToString(x);
    int result = 0;
    int[] array = new int[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        array [i] = Convert.ToInt32(str[i].ToString());
        result = result + array[i];
    }
    return result;
}

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(GetNumberSumm(number));