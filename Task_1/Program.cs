/* Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int Promt (string message)
{
    System.Console.Write(message);
    int ret = int.Parse(Console.ReadLine());
    return ret;
}

int Pow (int a, int b)
{
    int res = a;
    for (int i=1; i < b; i++)
    {
        res = res * a;
    }
return res;
}

int[] numbers = new int[5];

int number = Promt("Enter 5 digits number: ");

if (number < 10000 || number > 99999)
    System.Console.WriteLine("Fatal Error! Incorrect number! Please try again.");
else
{
    for(int i=1; i <= 5; i++)
    {
        numbers[i-1] = number % Pow(10,i);
        if (i >= 2)
            numbers[i-1] = numbers[i-1] / Pow(10,i-1);
        
    }

if(numbers[0] == numbers[4] && numbers[1] == numbers[3] )
    System.Console.WriteLine("Yes!");
else
    System.Console.WriteLine("No!");
}