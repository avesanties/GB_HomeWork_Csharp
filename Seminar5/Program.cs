/*
26.04.2022
Шлепенков Алексей
Telegram: @avesanties
Discord: Alexey Sh.#3490
e-mail: schlepenkow@gmail.com
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 1: Напишите цикл, который принимает
на вход два числа (A и B) и возводит число A
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
**/
/*
bool IsNumberNotCorrect(int deg){
    if(deg < 1)
        return true;
    else
        return false;
}

int CalculateDegreeNumber(int num, int deg){
    int resNum = num;
    for(int i = 2; i <= deg; i++){
        resNum *= num;
    }
    return resNum;
}

Console.WriteLine(@"Программа вычисляет для числа A степень B");

Console.WriteLine("Введите число А:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int degree = Convert.ToInt32(Console.ReadLine());

if(IsNumberNotCorrect(degree)){
    Console.WriteLine("Степень числа должна быть натуральным числом!");
    return;
}

int resultNumber = CalculateDegreeNumber(number, degree);

Console.WriteLine($"{number}, {degree} -> {resultNumber}");
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 2: Напишите программу, которая
принимает на вход число и выдаёт сумму 
цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
**/
/*
int CalculateDigitsSum(int num){
    int digSum = 0;
    while(num > 0){
        digSum += num % 10;
        num /= 10;
    }
    return digSum;
}

Console.WriteLine(@"Программа возвращает сумму цифр числа");

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int digitsSum = CalculateDigitsSum(number);

Console.WriteLine($"{number} -> {digitsSum}");
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 3: Напишите программу, которая задаёт
массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
**/
/*
int[] CreateArray(int arLen){
    Random rand = new Random();
    int minNum = -1000;
    int maxNum = 1000;

    int[] arr = new int[arLen];
    for(int i = 0; i < arr.Length; i++){
        arr[i] = rand.Next(minNum,maxNum);
    }
    return arr;
}

void ShowArray(int[] arr){
    string arStr = "[";
    string numStr = "";
    for(int i = 0; i < arr.Length; i++){
        arStr += arr[i] + ", ";
        numStr += arr[i] + ", ";
    }
    arStr = arStr.Substring(0,arStr.Length - 2) + "]";
    numStr = numStr.Substring(0,numStr.Length - 2);

    Console.WriteLine($"{numStr} -> {arStr}");
}

Console.WriteLine(@"Программа возвращает массив из восьми элементов");

int arrayLength = 8;

int[] array = CreateArray(arrayLength);

ShowArray(array);
**/
