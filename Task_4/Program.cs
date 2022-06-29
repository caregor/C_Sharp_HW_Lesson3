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

int[] numbers = new int[10];
int palendrom = 0;

int number = Promt("Enter 5 digits number: ");

if (number < 10)
    System.Console.WriteLine("Fatal Error! Incorrect number! Please try again.");
else
{
    
    for(int i=1; i <= numbers.Length; i++)
    {
        numbers[i-1] = number % Pow(10,i);
        if (i >= 2)
            numbers[i-1] = numbers[i-1] / Pow(10,i-1);
    }

    int tmp = numbers.Length;
    for (int y = tmp - 1; y > 2; y--)
    {
        if(numbers[y] == 0)
            Array.Resize(ref numbers, numbers.Length - 1);
        else
            break;
    }
    
    for (int j = 0; j < numbers.Length / 2; j++)
    {
        if (numbers[j] == numbers[numbers.Length - 1 - j])
        {
            palendrom = 1;
        }
        else
        {
            palendrom = -1;
            break;
        }    
    }
}

if (palendrom == 1)
    System.Console.WriteLine("Yes");
else if(palendrom == -1)
    System.Console.WriteLine("No");
else
    System.Console.WriteLine("Something wrong");