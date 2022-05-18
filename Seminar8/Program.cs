/*
23.05.2022
Шлепенков Алексей
Telegram: @avesanties
Discord: Alexey Sh.#3490
e-mail: schlepenkow@gmail.com
*/
//////////////////////////////////////////////////////////////////////////////
/* Задача 1. Описание.
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8
*/
/* Задача 1. Решение.
void ShowMatrix(int[,] _matrix){
    for(int i = 0; i < _matrix.GetLength(0); i++){
        for(int j = 0; j < _matrix.GetLength(1); j++){
            Console.Write(_matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateMatrix(int _strSize, int _colSize){
    int[,] _matrix = new int[_strSize,_colSize];

    int _matrixNumLimit = 100;
    for(int i = 0; i < _strSize; i++)
        for(int j = 0; j < _colSize; j++){
            _matrix[i,j] = new Random().Next(_matrixNumLimit);
        }
    
    return _matrix;
}

int[,] SortMatrix(int [,] _matrix){
    int _matrixRows = _matrix.GetLength(0);
    int _matrixCols = _matrix.GetLength(1);

    for(int i = 0; i < _matrixRows; i++){
        
        //Сортировка пузырьком
        for(int m = 0; m < _matrixCols; m++){
            int temp = 0;
            for(int n = 0; n < _matrixCols - m - 1; n++){
                if(_matrix[i,n] >_matrix[i,n+1] ){
                    temp = _matrix[i,n+1];
                    _matrix[i,n+1] = _matrix[i,n];
                    _matrix[i,n] = temp;
                }
            }
        }
    }

    return _matrix;
}
Console.WriteLine("Программа возвращает двумерный массив, в котором элементы" + 
                    " упорядочены по взрастанию.\n");

int matrixSizeLimit = 10;
int matrixStrSize = new Random().Next(2,matrixSizeLimit);
int matrixColSize = new Random().Next(2,matrixSizeLimit);

int [,] matrix = CreateMatrix(matrixStrSize,matrixColSize);

ShowMatrix(matrix);

SortMatrix(matrix);
Console.WriteLine("В итоге получается вот такой массив:\n");

ShowMatrix(matrix);
*/
//////////////////////////////////////////////////////////////////////////////
/* Задача 2. Описание.
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/* Задача 2. Решение.
void ShowMatrix(int[,] _matrix){
    for(int i = 0; i < _matrix.GetLength(0); i++){
        for(int j = 0; j < _matrix.GetLength(1); j++){
            Console.Write(_matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateMatrix(int _strSize, int _colSize){
    int[,] _matrix = new int[_strSize,_colSize];

    int _matrixNumLimit = 100;
    for(int i = 0; i < _strSize; i++)
        for(int j = 0; j < _colSize; j++){
            _matrix[i,j] = new Random().Next(_matrixNumLimit);
        }
    
    return _matrix;
}

int FindSmallestRowSum(int[,] _matrix){
    int _smallestSumRow = 0;
    int _smallestSum = 0;

    for(int i = 0; i < _matrix.GetLength(0); i++){
        int _tempSum = 0;

        for(int j = 0; j < _matrix.GetLength(1); j++){
            _tempSum += _matrix[i,j];
        }
        if(_tempSum < _smallestSum || i == 0){
            _smallestSum = _tempSum;
            _smallestSumRow = i;
        }
    }

    return _smallestSumRow;
}
Console.WriteLine("Программа возвращает номер строки с наимененьшей суммой элементов.");

int matrixSizeLimit = 5;
int matrixStrSize = new Random().Next(2,matrixSizeLimit);
int matrixColSize = new Random().Next(2,matrixSizeLimit);

int [,] matrix = CreateMatrix(matrixStrSize,matrixColSize);

ShowMatrix(matrix);

Console.WriteLine("Номер строки с наименьшей суммой: "+ FindSmallestRowSum(matrix));
*/
//////////////////////////////////////////////////////////////////////////////
/* Задача 3. Описание.
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
/* Задача 3. Решение.
int [,] CreateMatrix(int _rowSize, int _colSize){
    int[,] _matrix = new int[_rowSize,_colSize];
    int _matrixMaxStartNum = 100;
    int _matrixElementVal = new Random().Next(_matrixMaxStartNum);
    int _countElement = 0;
    int _currRow = 0;
    int _currCol = 0;
    bool _directionVertical = false;
    int _step = 1;
    while(_countElement < _rowSize * _colSize){
        _matrix[_currRow,_currCol] = _matrixElementVal++;
        _countElement++;

        if(
            _currCol == _colSize-1 && _currRow == 0
            || _currRow == _rowSize - 1 && _currCol == _colSize - 1
            || _currCol == 0 && _currRow == _rowSize - 1){
            
            if(_directionVertical){
                _step = -_step;
            }
            _directionVertical = !_directionVertical;
        }
        if(_currCol + _step < _colSize &&  _currCol + _step >= 0 ){
            if(_matrix[_currRow,_currCol + _step] != 0 && !_directionVertical){
                if(_directionVertical){
                _step = -_step;
                }
            _directionVertical = !_directionVertical;
            }
        }
        if( _currRow + _step < _rowSize && _currRow + _step >= 0){
            if(_matrix[_currRow + _step,_currCol] != 0 && _directionVertical || _currRow + _step == 0 && _currCol == 0){
                if(_directionVertical){
                _step = -_step;
                }
            _directionVertical = !_directionVertical;
            }
        }

        if(_directionVertical){
            _currRow += _step;
        }
        else{
            _currCol += _step;
        }
    }
    
    return _matrix;
}

void ShowMatrix(int[,] _matrix){
    for(int i = 0; i < _matrix.GetLength(0); i++){
        for(int j = 0; j < _matrix.GetLength(1); j++){
            Console.Write(_matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Программа возвращает двумерный массив 4х4, заполненный по спирали.");

int matrixStrSize = 10;
int matrixColSize = 10;

ShowMatrix(CreateMatrix(matrixStrSize,matrixColSize));
*/
