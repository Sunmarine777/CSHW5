//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


using System.Data;
using System.Numerics;
using System.Globalization;


int rows = new int();

int cols = new int();

int[,] matrix = new int[rows, cols];
Random rand = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
          matrix[i,j] = rand.Next(5,10);  
      }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
          Console.Write(matrix[i,j] + " ");
      }
       Console.WriteLine();
}

/*
Console.WriteLine("Enter matrix rows: ");
int rows = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter matrix columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, cols];
Random rand = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
          matrix[i,j] = rand.Next(5,10);  
      }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
          Console.Write(matrix[i,j] + " ");
      }
       Console.WriteLine();
}
*/

/*
int rows = new int();
int cols = new int();
//int[,] matrix = new int[rows, cols];
Random rand = new Random();

for (int i = 0; i < cols; i++)
{
      for (int j = 0; j < rows; j++)
      {
            matrix[i,j] = rand.Next(5,10);
      }
}
int[,] matrix = GenerateMatrix(rows, cols, 5, 10);
Console.WriteLine(matrix);
PrintMatrix(matrix);
*/
/*
int rows = new int();

int cols = new int();

int[,] matrix = new int[rows, cols];
Random rand = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
          matrix[i,j] = rand.Next(5,10);  
      }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
          Console.Write(matrix[i,j] + " ");
      }
       Console.WriteLine();
}*/

/*
int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
      int[,] tempMatrix = new int[row, col];
      Random rand = new Random();
      for (int i = 0; i < tempMatrix.GetLength(0); i++)
      {

            for (int j = 0; j < tempMatrix.GetLength(1); j++)
            {
                  tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
                   }
      } return tempMatrix;
      }
      void PrintMatrix(int[,] matrixForPrint)
      {
            for (int i = 0; i < matrixForPrint.GetLength(0); i++)
            {
                  for (int j = 0; j < matrixForPrint.GetLength(1); j++)
                  {
                        System.Console.Write(matrixForPrint[i, j] + "\t");
                  }
                        System.Console.WriteLine();
            }
      }
      int rows = ReadInt("Введите количество строк в матрице: ");
      int cols = ReadInt("Введите количество столбцов в матрице: ");
      int[,] matrix = GenerateMatrix(rows, cols, 0, 10);
      PrintMatrix(matrix);
*/

