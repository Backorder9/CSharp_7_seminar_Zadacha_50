/* Задача 50.
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
// int [,] Num = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
string ArrayElement(string a, string b)
{
   int [,] Num = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
   int x = Num.GetLength(0);
   int y = Num.GetLength(1);
   int i = int.Parse(a);
   int j = int.Parse(b);
   string c = String.Empty;
   if (i > x-1 || j > y-1) c = "такого числа в массиве нет";
   else c = Num[i,j].ToString();
   return c;
}

Console.WriteLine();
Console.Write("Введите индекс строки элемента массива: ");
string m = Console.ReadLine();
Console.WriteLine();
Console.Write("Введите индекс столбца элемента массива: ");
string n = Console.ReadLine();
Console.WriteLine();
string L = ArrayElement(m, n);
Console.Write($"Элемент массива с индексами ({m},{n}): {L}");