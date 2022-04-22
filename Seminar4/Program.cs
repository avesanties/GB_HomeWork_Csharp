/*
22.04.2022
Шлепенков Алексей
Telegram: @avesanties
Discord: Alexey Sh.#3490
e-mail: schlepenkow@gmail.com
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 34: Задайте массив заполненный 
случайными положительными трёхзначными
числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
**/
/*
bool IsArrayLengthNotCorrect(int arLen){
    if(arLen < 1)
        return true;
    else
        return false;
}

int[] CreateArray(int arLen){
    Random rand = new Random();
    int minNum = 100;
    int maxNum = 1000;

    int[] arr = new int[arLen];
    for(int i = 0; i < arr.Length; i++){
        arr[i] = rand.Next(minNum,maxNum);
    }
    return arr;
}

int FindEvenNumberAmount(int[] arr){
    int evenNumAmnt = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i]%2==0)
            evenNumAmnt++;
    }
    return evenNumAmnt;
}

string TurnArrayToString(int[] arr){
    string arStr = "[";
    for(int i = 0; i < arr.Length; i++){
        arStr += arr[i] + ", ";
    }
    return arStr.Substring(0,arStr.Length - 2) + "]";
}

Console.WriteLine(@"Программа формирует массив случайных трехзначных чисел c указанной длиной,
                    выводит количество четных чисел");


Console.WriteLine("Укажите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

if(IsArrayLengthNotCorrect(arrayLength)){
    Console.WriteLine("Размер массива не может быть меньше 1!");
    return;
}

int[] array = CreateArray(arrayLength);

int evenNumAmount = FindEvenNumberAmount(array);

string stringArray = TurnArrayToString(array);

Console.WriteLine($"{stringArray} -> {evenNumAmount}");
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 36: Задайте одномерный массив,
заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
**/
/*
bool IsArrayLengthNotCorrect(int arLen){
    if(arLen < 1)
        return true;
    else
        return false;
}

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

int CalculateOddIndexesSum(int[] arr){
    int oddInSum = 0;
    for(int i = 0; i < arr.Length; i++){
        if(i % 2 > 0)
            oddInSum += arr[i];
    }
    return oddInSum;
}

string TurnArrayToString(int[] arr){
    string arStr = "[";
    for(int i = 0; i < arr.Length; i++){
        arStr += arr[i] + ", ";
    }
    return arStr.Substring(0,arStr.Length - 2) + "]";
}

Console.WriteLine(@"Программа формирует массив случайных чисел с указанной длиной,
                    выводит сумму элементов с нечетным индексом");


Console.WriteLine("Укажите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

if(IsArrayLengthNotCorrect(arrayLength)){
    Console.WriteLine("Размер массива не может быть меньше 1!");
    return;
}

int[] array = CreateArray(arrayLength);

int oddIndexesSum = CalculateOddIndexesSum(array);

string stringArray = TurnArrayToString(array);

Console.WriteLine($"{stringArray} -> {oddIndexesSum}");
**/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
**/
/*
bool IsArrayLengthNotCorrect(int arLen){
    if(arLen < 1)
        return true;
    else
        return false;
}

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

int FindArrayMaxItem(int[] arr){
    int maxItem = arr[0];
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] > maxItem)
            maxItem = arr[i];
    }
    return maxItem;
}

int FindArrayMinItem(int[] arr){
    int minItem = arr[0];
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] < minItem)
            minItem = arr[i];
    }
    return minItem;
}

string TurnArrayToString(int[] arr){
    string arStr = "[";
    for(int i = 0; i < arr.Length; i++){
        arStr += arr[i] + ", ";
    }
    return arStr.Substring(0,arStr.Length - 2) + "]";
}

Console.WriteLine(@"Программа формирует массив случайных чисел с указанной длиной,
                    выводит разницу между максимальным и минимальным элементами массива");


Console.WriteLine("Укажите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

if(IsArrayLengthNotCorrect(arrayLength)){
    Console.WriteLine("Размер массива не может быть меньше 1!");
    return;
}

int[] array = CreateArray(arrayLength);

int arrayMaxMinitemDiff = FindArrayMaxItem(array) - FindArrayMinItem(array);

string stringArray = TurnArrayToString(array);

Console.WriteLine($"{stringArray} -> {arrayMaxMinitemDiff}");
**/