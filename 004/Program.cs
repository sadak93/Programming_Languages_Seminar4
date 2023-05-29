// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
int[] Array = new int[8];
for (int i=0; i<Array.Length; i++)
{
    Array[i]=new Random().Next(0,2);
    System.Console.Write($"{Array[i]}, ");
}



// void Arr(int[] Array)
// {
//     for (int i = 0; i<Array.Length; i++)
//     {
//          Array[i] = new Random().Next(0, 2);
//          System.Console.Write($"{Array[i]}, ");
//     }
// }

// Console.Clear();
// int[] Array = new int[8];
// Arr(Array);


// void FillArray(int[] collection)
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index<Length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }

// }
// void PrintArray(int[] col)
// {   
//     int count = col.Length;
//     int position = 0;
//     while (position<count)
//     {
//         System.Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;

//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10];

// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();

// int pos = IndexOf(array, 44);
// System.Console.WriteLine(pos);
