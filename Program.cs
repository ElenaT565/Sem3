// Заадача 21

/*Console.Write("Введите коорд точки Х1: ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите коорд точки Y1: ");
int Y1 = int.Parse(Console.ReadLine());
Console.Write("Введите коорд точки Z1: ");
int Z1 = int.Parse(Console.ReadLine());
Console.Write("Введите коорд точки Х2: ");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Введите коорд точки Y2: ");
int Y2 = int.Parse(Console.ReadLine());
Console.Write("Введите коорд точки Z2: ");
int Z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2) + Math.Pow(Z2-Z1,2));
Console.WriteLine($"Расстояние равно - {result:f2}");*/

//Задача 23

/*Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());

for (int I = 1; I <= Num; I ++)
{
    double result = Math.Pow(I,3);
    Console.Write($"{result} ");
}*/

// Задача 19

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

int A1 = A / 10000;
int A2 = (A/1000) % 10;
int A4 = (A % 100) / 10;
int A5 = A % 10;

if ((A2 == A4)&&(A1 == A5))

   Console.Write($"Число {A} полиндром");

else 

Console.Write($"Число {A} не полиндром");
