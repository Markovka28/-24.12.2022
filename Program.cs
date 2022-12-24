/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
    
Console.Write("Введите пятизначное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int r, sum = 0;
            int temp = n;
            while (n > 0)
            {
        r = n % 10;
                sum = (sum * 10) + r;
                n /= 10; 
            }
            if (temp == sum)
            {
                Console.WriteLine($"Введенное число палиндром");
            }
            else
            {
                Console.WriteLine($"Число не явлется палиндромом");
            }*/

            

/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

Console.Clear(); 
Console.Write("Введите X1: ");
int x1=int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1=int.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
int x2=int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2=int.Parse(Console.ReadLine());
Console.Write("Введите W1: ");
int w1=int.Parse(Console.ReadLine());
Console.Write("Введите W2: ");
int w2=int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(w1-w2, 2));

Console.WriteLine($"d={d:f5}");*/
