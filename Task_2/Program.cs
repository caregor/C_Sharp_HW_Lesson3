/* Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

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

int x1 = Promt("Enter x1: ");
int y1 = Promt("Enter y1: ");
int z1 = Promt("Enter z1: ");

int x2 = Promt("Enter x2: ");
int y2 = Promt("Enter y2: ");
int z2 = Promt("Enter z2: ");

double res = Math.Sqrt(Pow(x2-x1,2) + Pow(y2-y1,2) + Pow(z2-z1,2));
System.Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {res:F}");