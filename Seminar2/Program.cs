/*
12.04.2022
Шлепенков Алексей
Telegram: @avesanties
Discord: Alexey Sh.#3490
e-mail: schlepenkow@gmail.com
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 10: Напишите программу,
которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
**/
/*
int FindSecondDigit(int num){
    int digitOrder = 10;
    int numberOrder = 100;
    return num%numberOrder/digitOrder;
}

bool IsNumberNotCorrect(int num){
    int lowerBorder = 100;
    int upperBorder = 999;
    if(num < lowerBorder || upperBorder < num){
        return true;
    }
    else{
        return false;
    }
}

Console.WriteLine("Вывод второй цифры трехзначного числа");

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if(IsNumberNotCorrect(number)){
    Console.WriteLine("Введено некорректное число!");
    return;
}

int secondDigit = FindSecondDigit(number);
Console.WriteLine($"{number} -> {secondDigit}");
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 13: Напишите программу,
которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
**/
/*
bool IsNumberNotCorrect(int num, int baseNum, int minOrd){
    int lowerBorder = Convert.ToInt32(Math.Pow(baseNum,minOrd));
    if(num < lowerBorder){
        return true;
    }
    else{
        return false;
    }
}

int FindThirdDigit(int num, int baseNum, int minOrd){
    int order = 0;
    int orderNumber = 1;
    int divisionResult = 0;
    do{
        order++;
        orderNumber *= baseNum;
        divisionResult = num / orderNumber;
    }while(divisionResult > 0);
    order -= 1;
    
    return (num/Convert.ToInt32(Math.Pow(baseNum,order - minOrd)))%baseNum;
}

Console.WriteLine("Вывод третьей цифры числа или сообщение об отсутствии таковой");

int baseNumber = 10;
int minOrder = 2;

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if(IsNumberNotCorrect(number,baseNumber,minOrder)){
    Console.WriteLine("Третьей цифры нет!");
    return;
}

int thirdDigit = FindThirdDigit(number,baseNumber,minOrder);

Console.WriteLine($"{number} -> {thirdDigit}");
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 15: Напишите программу,
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
**/
/*
bool isDayNotCorrect(int day){
    if(day<1 || 7<day)
        return true;
    else
        return false;
}

bool isDayWeekend(int day){
    if(day == 6 || day == 7)
        return true;
    else 
        return false;
}

Console.WriteLine("Вывод результата проверки, явялется ли день выходным");

Console.WriteLine("Введите номер дня: ");
int inputDay = Convert.ToInt32(Console.ReadLine());

if(isDayNotCorrect(inputDay)){
    Console.WriteLine("Введен некорректный номер дня!");
    return;
}

if(isDayWeekend(inputDay))
    Console.WriteLine($"{inputDay} -> да");
else
    Console.WriteLine($"{inputDay} -> нет");
**/