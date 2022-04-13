/*
12.04.2022
Шлепенков Алексей
Telegram: @avesanties
Discord: Alexey Sh.#3490
e-mail: schlepenkow@gmail.com
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 1: Напишите программу, 
которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
**/
/*
Console.WriteLine("Вычисление максимального и минимального из двух чисел");

Console.WriteLine("Введите число a");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b");
double num2 = Convert.ToDouble(Console.ReadLine());

if(num1>num2)
    Console.WriteLine($"Наибольшее: {num1}, наименьшее: {num2}");
else if(num2>num1)
    Console.WriteLine($"Наибольшее: {num2}, наименьшее: {num1}");
else
    Console.WriteLine("Числа равны");
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 2: Напишите программу,
которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
**/
/*
Console.WriteLine("Вычисление максимального из трех чисел");

double max;
double num;

Console.WriteLine("Введите число a");
max = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b");
num = Convert.ToDouble(Console.ReadLine());
if (num > max)
    max = num;

Console.WriteLine("Введите число c");
num = Convert.ToDouble(Console.ReadLine());
if (num > max)
    max = num;

Console.WriteLine($"Максимальное число: {max}");
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 3: Напишите программу, 
которая на вход принимает число и выдаёт,
является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
**/
/*
Console.WriteLine("Является ли число четным?");

Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 4: Напишите программу,
которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
**/
/*
Console.WriteLine("Отображение четных чисел от 2 до N");

int startPoint = 2;
int delta = 2;
int count = 1;
int interSum = startPoint;
string strResult = "";

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if(N < startPoint){
    Console.WriteLine("Число вне диапазона");
    return;
}

while (interSum <= N){
    strResult += interSum + ", ";
    interSum = startPoint + delta * count;
    count++;
}

strResult = strResult.Substring(0,strResult.Length-2);

Console.WriteLine(strResult);
**/