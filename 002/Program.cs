// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



Console.Clear();
System.Console.WriteLine("Ввести целое число ");
int num = Math.Abs(Convert.ToInt32 (Console.ReadLine()));
int count = 0;
while (num >=1)
{
    num=num/10;
    count++;
}
System.Console.WriteLine(count);

// int Kol(int num)
// {
//     int count = 0;
//     if (num == 0) return 1;
//     while (num >= 1)
//     {
//          num=num/10;
//          count++;
//     }
//     return count;
// }

// Console.Clear();
// System.Console.WriteLine("Ввести целое число ");
// int num = Math.Abs(Convert.ToInt32 (Console.ReadLine()));

// System.Console.WriteLine(Kol(num));
