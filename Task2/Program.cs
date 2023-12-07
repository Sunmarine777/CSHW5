//Задача 2: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.


int rows = 3;
int cols = 4;
int[,] matrix = new int[rows,cols];

Random rand = new Random();

int[,] First = new int[rows,cols];
int[,] Last = new int[rows,cols];
int FirstStr = 0;
int LastStr = 2;

int[,] tempmatrix = new int[rows,cols];

for (int i = 0; i < rows; i++)
{
      for (int j = 0; j < cols; j++)
      {
            matrix[i,j] = rand.Next(1,50);
            Console.Write(matrix[i,j] + "\t");
      }
      Console.WriteLine();
}

for (int i = 0; i < rows; i++)
{
     for (int j = 0; j < cols; j++)
      {
            if (i == FirstStr)
            {
                  First[i,j] = matrix[i,j];
                  FirstStr = i;
            }
      }
}

for (int i = 0; i < rows; i++)
{
      for (int j = 0; j < cols; j++)
      {
            if (i == LastStr)
            {
                  Last[i,j] = matrix[i,j];
                  LastStr = i;
            }
      }
}

Console.WriteLine();

for (int i = FirstStr, j = 0; j < cols; j++)
{
      
      tempmatrix[FirstStr,j] = matrix[i,j]; // забрал первую
}

for (int i = LastStr, j = 0; j < cols; j++)
{
      matrix[FirstStr,j] = matrix[LastStr, j]; //первая строка получает из последней
}

for (int i = 0; i < rows; i++)
{
     for (int j = 0; j < cols; j++)
      {
            matrix[LastStr, j] = tempmatrix[FirstStr,j]; // последняя получает из первой
      }
}

for (int i = 0; i < rows; i++)
{
     for (int j = 0; j < cols; j++)
      {
            Console.Write(matrix[i,j] + "\t");
      }
      Console.WriteLine();
}
Console.ReadKey();