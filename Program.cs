/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.*/
    
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
            }