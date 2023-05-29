// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Summa(int num)
{
    int result = 1;
    for (int i=1; i<=num; i++)
        result=result*i;
    return result;
}

Console.Clear();
System.Console.WriteLine("Ввести натуральное целое число ");
int num = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine($"Произведение чисел от 1 до {num} равна {Summa(num)}");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

