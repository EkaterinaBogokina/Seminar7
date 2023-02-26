
//Задача 47. Задайте двумерный массив размером m * n, заполненный случайными вещественными числами.

 int numRows = userNum("Rows");
 int numColumns = userNum("Columns");
 var matrix = Matrix(numRows, numColumns);
 PrintMatrix(matrix);

int userNum(string userNumber)  
{
    Console.Write($"Enter number {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] Matrix(int rows, int columns) 
{
    double[,] matrix = new double[rows, columns];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Convert.ToDouble(rand.Next(-100, 100) / 10.0);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
//Задача 50. Напишите программу, 
//которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int numRows = userNum("Rows");
int numColumns = userNum("Columns");

int numMinValue = userNum("Min Value");
int numMaxValue = userNum("Max Value");
int[,] matrix = Matrix(numRows, numColumns, numMinValue, numMaxValue);
PrintMatrix(matrix);
IndexValue(matrix);
var myMatrix = Matrix(numRows, numColumns, numMinValue, numMaxValue);
PrintMatrix(matrix);

int userNum(string userNumber)  
{
    Console.Write($"Enter number {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] Matrix(int rows, int columns, int min, int max)  
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10)
                System.Console.Write("" + matrix[i, j] + " ");
            else
                System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void IndexValue(int[,] matrix)  
{
    int indexRow = userNum("индекс строки");
    int indexColumn = userNum("индекс столбца");

    if (indexRow > matrix.GetLength(0) || indexColumn > matrix.GetLength(1))
        System.Console.WriteLine("No element");
    else
    {
        System.Console.WriteLine($"Element: {matrix[indexRow, indexColumn]}");
    }
}

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int numRows = UserNum("Rows");
int numColumns = UserNum("Columns");
int numMinValue = UserNum("Min Value");
int numMaxValue = UserNum("Max Value");
int[,] matrix = Matrix(numRows, numColumns, numMinValue, numMaxValue);
PrintMatrix(matrix);
Console.WriteLine($"Среднее арифметическое: ");
ArithmeticalMean(matrix);

          

int UserNum(string userNumber)  
{
    Console.Write($"Введите значение {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}


int[,] Matrix(int rows, int columns, int min, int max)  
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10)
                System.Console.Write("" + matrix[i, j] + " ");
            else
                System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


void ArithmeticalMean(int[,] matrix)  //  Метод для вычисления среднего арифметического по столбцам
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        double mean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        mean = sum / matrix.GetLength(0);
        System.Console.WriteLine($"столбец {j}: {mean}");
    }
}

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int size = UserNum("размер матрицы");
int[,] matrix = new int[size, size];
SpiralMatrix(matrix);
PrintMatrix(matrix);

int UserNum(string userNumber) 
{
    Console.Write($"Enter number {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintMatrix(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10)
                System.Console.Write("" + matrix[i, j] + " ");
            else
                System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] SpiralMatrix(int[,] matrix)  
{
    int value = 1;
    int size = matrix.GetLength(0);
    int maxIndex = size - 1;
    int i = 0;
    int j = 0;

    while (value <= size * size)
    {
        matrix[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < maxIndex)
            j++;
        else if (i < j && i + j >= maxIndex)
            i++;
        else if (i >= j && i + j > maxIndex)
            j--;
        else
            i--;
    }
    return matrix;
}

