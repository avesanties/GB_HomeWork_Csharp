/*
23.05.2022
Шлепенков Алексей
Telegram: @avesanties
Discord: Alexey Sh.#3490
e-mail: schlepenkow@gmail.com
*/
//////////////////////////////////////////////////////////////////////////////////////////
/* Задача 1. Описание.
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/* Задача 1. Решение.
int Sum (int _m, int _n){
    if(_m < _n)
        return _n + Sum(_m, _n - 1);
    else 
        return _m;
}

Console.WriteLine("Программа возвращает сумму натуральный чисел на отрезке от M до N.");

int M = new Random().Next(10);
int N = new Random().Next(10,20);

Console.WriteLine($"M = {M}; N = {N} -> {Sum(M,N)}");
*/
//////////////////////////////////////////////////////////////////////////////////////////
/* Задача 2. Описание.
Задача 67: Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.

453 -> 12
45 -> 9
*/
/* Задача 2. Решение.
int CalculateDigitSum(int _num){
    if(_num > 0)
        return _num % 10 + CalculateDigitSum(_num / 10);
    else
        return 0;
}

Console.WriteLine("Программа возвращает сумму цифр числа.");

int num = new Random().Next(10000);

Console.WriteLine($"{num} -> {CalculateDigitSum(num)}");
*/