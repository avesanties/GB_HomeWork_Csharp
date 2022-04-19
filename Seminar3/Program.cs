/*
19.04.2022
Шлепенков Алексей
Telegram: @avesanties
Discord: Alexey Sh.#3490
e-mail: schlepenkow@gmail.com
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 19
Напишите программу,
которая принимает на вход
пятизначное число и проверяет,
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
**/
/*
bool IsNumberPalindrome(int num, int numBase){
    int checkedPalindromNum = 0;
    int dividedNum = num;

    do {
        checkedPalindromNum = checkedPalindromNum * numBase + dividedNum % 10;
        dividedNum /= 10;
    }while(dividedNum > 0);

    if (checkedPalindromNum == num)
        return true;
    else
        return false;
}

bool IsNumberNotCorrect(int num, int numBase){
    if(num < numBase)
        return true;
    else
        return false;
}

Console.WriteLine("Программа проверяет, является ли введенное число палиндромом");

int numberBase = 10;

Console.WriteLine("Введите число:");
int inputNumber = Convert.ToInt32(Console.ReadLine());

if(IsNumberNotCorrect(inputNumber,numberBase)){
    Console.WriteLine("Такого палиндрома быть не может!");
    return;
}

if(IsNumberPalindrome(inputNumber, numberBase))
    Console.WriteLine($"{inputNumber} -> да");
else
    Console.WriteLine($"{inputNumber} -> нет");
**/
/*
Задача 21
Напишите программу, которая 
принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
**/
/*
double FindPointsDistance(double x1, double y1, double z1, double x2, double y2, double z2){
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
}

Console.WriteLine(@"Программа возвращает значение расстояния между двумя
                    точками трехмерного пространства");

Console.WriteLine("Введите координаты точки A: \nx\ny\nz\n");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: \nx\ny\nz\n");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double distanceAB = Math.Round(FindPointsDistance(x1, y1, z1, x2, y2, z2),2);

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {distanceAB})");
**/
/*
Задача 23
Напишите программу, которая 
принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
**/
/*
int CalculateCubicDegree(int num){
    return num * num * num;
}

bool IsNumberNotCorrect(int n){
    if(n < 1)
        return true;
    else 
        return false;
}

Console.WriteLine("Программа выводит числа от 1 до N, возведенные в куб");

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

if(IsNumberNotCorrect(N)){
    Console.WriteLine("Введено число меньше 1!");
    return;
}

string strResult = "";
for(int i=1; i<=N; i++){
    strResult += CalculateCubicDegree(i) + ", ";
}

strResult = strResult.Substring(0,strResult.Length-2);

Console.WriteLine($"{N} -> {strResult}");
**/