//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.


int rows = 5;
int cols = 5;
int[,] matrix = new int[rows,cols];

Random rand = new Random();

int sum0 = 0;
int sum1 = 0;
int sum2 = 0;
int sum3 = 0;
int sum4 = 0;

int min = 0;

for (int i = 0; i < rows; i++)
{
      for (int j = 0; j < cols; j++)
      {
            matrix[i,j] = rand.Next(10,50);
            Console.Write(matrix[i,j] + " ");
      }
      Console.WriteLine();
}

for (int i = 0, j = 0; j < cols; j++)
{
      sum0 += matrix[i,j];
}

for (int i = 1, j = 0; j < cols; j++)
{
      sum1 += matrix[i,j];
}

for (int i = 2, j = 0; j < cols; j++)
{
      sum2 += matrix[i,j];
}

for (int i = 3, j = 0; j < cols; j++)
{
      sum3 += matrix[i,j];
}

for (int i = 4, j = 0; j < cols; j++)
{
      sum4 += matrix[i,j];
}

if (sum0 < sum1)
{
      min = sum0;
}
if (sum1 < sum2)
{
      min = sum1;
}
if (sum2 < sum3)
{
      min = sum2;
}
if (sum3 < sum4)
{
      min = sum3;
}
else
{
      min = sum4;
}

Console.WriteLine("Min sum of the row is: " + min);