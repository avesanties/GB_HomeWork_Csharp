/*
14.05.2022
Шлепенков Алексей
Telegram: @avesanties
Discord: Alexey Sh.#3490
e-mail: schlepenkow@gmail.com
*/
//////////////////////////////////////////////////////////////////////////////
/* Задача 1. Описание.
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/* Задача 1. Решение.
void ShowMatrix(double[,] _matrix){
    for(int i = 0; i < _matrix.GetLength(0); i++){
        for(int j = 0; j < _matrix.GetLength(1); j++){
            Console.Write(_matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] CreateMatrix(int _strSize, int _colSize){
    double[,] _matrix = new Double[_strSize,_colSize];

    int _matrixNumLimit = 100;
    for(int i = 0; i < _strSize; i++)
        for(int j = 0; j < _colSize; j++){
            _matrix[i,j] = Math.Round(
                                        new Random().NextDouble() * _matrixNumLimit
                                        ,2);
        }
    
    return _matrix;
}
Console.WriteLine("Программа возвращает двумерный массив,"
                    + " заполненный случайными числами\n");

int matrixSizeLimit = 10;
int matrixStrSize = new Random().Next(2,matrixSizeLimit);
int matrixColSize = new Random().Next(2,matrixSizeLimit);

ShowMatrix(
        CreateMatrix(matrixStrSize,matrixColSize));
*/
//////////////////////////////////////////////////////////////////////////////
/* Задача 2. Описание.
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
/* Задача 2. Решение.
void ShowMatrix(double[,] _matrix){
    for(int i = 0; i < _matrix.GetLength(0); i++){
        for(int j = 0; j < _matrix.GetLength(1); j++){
            Console.Write(_matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] CreateMatrix(int _strSize, int _colSize){
    double[,] _matrix = new Double[_strSize,_colSize];

    int _matrixNumLimit = 100;
    for(int i = 0; i < _strSize; i++)
        for(int j = 0; j < _colSize; j++){
            _matrix[i,j] = Math.Round(
                                        new Random().NextDouble() * _matrixNumLimit
                                        ,2);
        }
    
    return _matrix;
}
Console.WriteLine("Программа возвращает значение двумерного массива"
                    + " по указанным индексам");

Console.WriteLine("Введите номер строки и столбца: m,n");
String inputIndexes = Console.ReadLine();
int userStrIndex = Convert.ToInt32(inputIndexes.Split(',').GetValue(0));
int userColIndex = Convert.ToInt32(inputIndexes.Split(',').GetValue(1));

int matrixSizeLimit = 10;
int matrixStrSize = new Random().Next(2,matrixSizeLimit);
int matrixColSize = new Random().Next(2,matrixSizeLimit);

double[,] matrix = CreateMatrix(matrixStrSize,matrixColSize);

ShowMatrix(matrix);

if(matrix.GetLength(0) < userStrIndex 
    || matrix.GetLength(1) < userColIndex) 
    Console.WriteLine("Элемента массива с таким индексом не существует!");
else Console.WriteLine(matrix[userStrIndex,userColIndex]);
*/
//////////////////////////////////////////////////////////////////////////////
/* Задача 3. Описание.
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/* Задача 3. Решение.
int[,] CreateMatrix(int _strSize, int _colSize){
    int[,] _matrix = new int[_strSize,_colSize];

    int _matrixNumLimit = 100;
    for(int i = 0; i < _strSize; i++)
        for(int j = 0; j < _colSize; j++)
            _matrix[i,j] = new Random().Next(_matrixNumLimit);
    
    return _matrix;
}

void ShowMatrix(int[,] _matrix){
    for(int i = 0; i < _matrix.GetLength(0); i++){
        for(int j = 0; j < _matrix.GetLength(1); j++)
            Console.Write(_matrix[i,j] + " ");
        Console.WriteLine();
    }
}

double CalculateMean(int[,] _matrix, int _colIndex){
    double _sum = 0;
    for(int m = 0; m < _matrix.GetLength(0); m++)
        _sum += _matrix[m,_colIndex];
    return Math.Round(
                    _sum / _matrix.GetLength(0)
                    ,1);
}

Console.WriteLine("Программа возвращает среднее арифмитическое значение"
                    + " каждого столбца двумерного массива\n");

int matrixSizeLimit = 10;
int matrixStrSize = new Random().Next(2,matrixSizeLimit);
int matrixColSize = new Random().Next(2,matrixSizeLimit);

int[,] matrix = CreateMatrix(matrixStrSize,matrixColSize);
ShowMatrix(matrix);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");
for(int i = 0; i < matrix.GetLength(1); i++){
    Console.Write(CalculateMean(matrix, i) + "; ");
}
Console.WriteLine();
*/