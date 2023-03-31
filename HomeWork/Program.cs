 //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool Palindrom(int num)
{
    int n = num;
    int rev = 0;
    while(n > 0)
    {
        int r = n %10;
        rev = rev * 10 + r;
        n /= 10;
    }

    return rev == num;
}

Console.WriteLine("Введите число ");
int n1 =Convert.ToInt32(Console.ReadLine());

if (Palindrom(n1))
    Console.WriteLine("Это число палиндром");
else
    Console.WriteLine("Число не палиндром");


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.  

// double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// }

// Console.Write("Введите x точки А: ");
//     int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите у точки А: ");
//     int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z точки А: ");
//     int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// Console.Write("Введите x точки B: ");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите у точки B: ");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите z точки B: ");
//     int z2 = Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine();

//  Console.WriteLine($"Расстояние между  А и В  {Math.Round(Distance (x1, y1, z1, x2, y2, z2), 2)}");

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Cub(int num)
// {
//     int i = 1;
//     while (i <= num)
//     {
//         Console.WriteLine($"{i} - {Math.Pow(i, 3)}");
//         i ++;
//     }
// }
// Console.Write("Введите число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Число num ");
// Cub(num);

