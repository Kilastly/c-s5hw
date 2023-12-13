/*Задача 1: Напишите программу, которая на вход принимает
 позиции элемента в двумерном массиве, и возвращает значение
  этого элемента или же указание, что такого элемента нет.
*/



// void InputMatrix(int[,] matrix)
//{
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 101);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void Serch(int[,] matrix, int[] poz)
// {
//  if(matrix.GetLength(0) > poz[0]-1 && matrix.GetLength(1) > poz[1]-1)
//  {
//    int i = poz[0] - 1;
//    int j = poz[1] - 1;
//    Console.WriteLine($"На позиции {i + 1} {j +1} элемент {matrix [i, j]}");  
//  }
// else
// Console.WriteLine($"В массиве {matrix.GetLength(0)} на {matrix.GetLength(1)} элемента нет!");
// }

// Console.Clear();
// Console.Write("Введите размеры двумерного массива через запятую: ");
// int[] size = Console.ReadLine()!.Split(',').Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.Write("Введите позицию элемента через запятую: ");
// int[] poz = Console.ReadLine()!.Split(',').Select(x => int.Parse(x)).ToArray();
// Serch(matrix, poz);

/*Задача 2: Задайте двумерный массив. 
Напишите программу, которая поменяет местами 
первую и последнюю строку массива.
*/

// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 101);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ReplaseRow(int[,] matrix)
// {

//     int[,] resultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)]; 

//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i == 0 || i == matrix.GetLength(0))
//             {
//                 if(i == 0)
//                 resultMatrix[i,j] = matrix[matrix.GetLength(0)-1,j];

//             }
//             else
//             if(i == matrix.GetLength(0)-1)
//             {
//                 resultMatrix[i,j] = matrix[0,j];
//             }
//             else
//             resultMatrix[i,j] = matrix[i,j];
//         }
//     }
//     return resultMatrix;
// }


// Console.Clear();
// Console.Write("Введите размеры двумерного массива через запятую: ");
// int[] size = Console.ReadLine()!.Split(',').Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальная матрица");
// PrintMatrix(matrix);
// int [,] resultMatrix = ReplaseRow(matrix);
// Console.WriteLine("Конечная матрица");
// PrintMatrix(resultMatrix);

/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить
строку с наименьшей суммой элементов.
*/



void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 101);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
bool CheckSqer (int[] size)
{
    if (size[0] == size[1])
    return true;
    else 
    return false;
}

int SumLine (int[,] matrix)
{
double minSum = 101*10; //умножаем максимальное значение заполнения матрицы на 10
int minLineIndex = 0;
int currentSum = 0;
  for(int j = 0; j < matrix.GetLength(0); j++)
    {
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
        currentSum = currentSum + matrix[i,j];
         
        {
        minSum = currentSum;
        minLineIndex = j;
        }
        }
    } 
    return minLineIndex;   
}




Console.Clear();
Console.Write("Введите размеры квадратного массива через запятую: "); //Можно было задать одним числом, но так понятней что массив двумерный
int[] size = Console.ReadLine()!.Split(',').Select(x => int.Parse(x)).ToArray();
bool check = CheckSqer(size);
if (check == false)
{
Console.Write("Вы ошиблись! Введите размеры квадратного массива через запятую: ");
size = Console.ReadLine()!.Split(',').Select(x => int.Parse(x)).ToArray();
}

int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Ваша матрица");
PrintMatrix(matrix);

int result = SumLine(matrix);

Console.WriteLine($"Строка с минимальной суммой {result}");