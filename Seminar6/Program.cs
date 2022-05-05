/*
05.05.2022
Шлепенков Алексей
Telegram: @avesanties
Discord: Alexey Sh.#3490
e-mail: schlepenkow@gmail.com
*/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
int GetInput(){
    Console.WriteLine("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Программа возвращает количество введенных пользователем чисел больших нуля");

int inputAmount = 5;
int naturalAmount = 0;
int naturalBorder = 0;
string inputStr = "";
int tempNum = 0;

for(int i = 1; i <= inputAmount; i++){
    tempNum = GetInput();
    inputStr += tempNum + ", ";

    if(tempNum > naturalBorder)
        naturalAmount++;
}

inputStr = inputStr.Substring(0,inputStr.Length-2);

Console.WriteLine($"{inputStr} -> {naturalAmount}");
*/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 42: Напишите программу, которая
будет преобразовывать десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10
*/
/*
string ConvertToBinInverse(string _numDecStr){
    int binBase = 2;
    int _numDec = Convert.ToInt32(_numDecStr);
    if(_numDec >= binBase){
        return _numDec % binBase + ConvertToBinInverse(Convert.ToString(_numDec / binBase));
    } 
    else{
        return Convert.ToString(_numDec);
    }
}

string ReverseString(string _str){
    char[] _charArr = _str.ToCharArray();
    char _temp;
    int _charArrLength = _charArr.Length;
    for(int i = 0; i < _charArrLength / 2; i++){
        _temp = _charArr[i];
        _charArr[i] = _charArr[_charArrLength - 1 - i];
        _charArr[_charArrLength - 1 - i] = _temp;
    }
    return new string(_charArr);
}

Console.WriteLine("Программа возвращает введенное число в двоичной системе счисления");

Console.WriteLine("Введите число:");
string numDec = Console.ReadLine();

string numBin = ConvertToBinInverse(numDec);
numBin = ReverseString(numBin);

Console.WriteLine($"{numDec} -> {numBin}");
*/
//////////////////////////////////////////////////////////////////////////////
/*
Задача 43: Напишите программу, которая
найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
/*
bool SolutionExists(double _k1, double _k2){
    if(_k1 != _k2)
        return true;
    else
        return false;
}

void ShowResult(double _k1, double _b1, double _k2, double _b2, double _x, double _y){
    Console.WriteLine($"b1 = {_b1}, k1 = {_k1}, b2 = {_b2}, k2 = {_k2} -> ({_x}; {_y})");
}

Console.WriteLine("Программа возвращает точку пересечения двух прямых");

int varAmount = 2;

Console.WriteLine("Введите значения коэффициентов первой прямой: \nk1\nb2");
double k1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения коэффициентов второй прямой: \nk2\nb2");
double k2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());

if(!(SolutionExists(k1, k2))){
    Console.WriteLine("Решения не существует или их бесконечно много!");
    return;
}

double x = (b2+b1) / (k1-k2);
double y = k1 * x + b1;

ShowResult(k1,b1,k2,b2,x,y);
*/