/*Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int rows = 10;
int columns = 10;
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
int position = ReadInt("Введите позицию элемента массива (двузначное число): ");
if (position / 10 >= 10)
{
    Console.WriteLine("Такой позиции нет в массиве");
}
int i1 = position /10;
int j2 = position % 10;
for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        if (i == i1 && j == j2)
        {
        Console.WriteLine(numbers [i1, j2]);
        }
    }
}



void FillMatrixRandomNumbers(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
for(int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 10);
}
}
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
