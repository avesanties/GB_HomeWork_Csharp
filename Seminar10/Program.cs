/*
24.05.2022
Шлепенков Алексей
Telegram: @avesanties
Discord: Alexey Sh.#3490
e-mail: schlepenkow@gmail.com
*/
//////////////////////////////////////////////////////////////////////////////
/* Задача 1. Описание.
Задача 1: Задайте массив строк. Напишите программу,
считает кол-во слов в массиве, начинающихся на гласную букву.

Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
*/
/* Задача 1. Решение.
string ShowArray(string[] _array){
    string _result = string.Empty;
    
    _result += "{ ";
    for(int i = 0; i < _array.Length; i++)
        _result += ($"\"{_array[i]}\", ");
    _result =_result.Substring(0,_result.Length - 2);
    _result += " }";

    return _result;
}

int CaclulateVowels(string[] _wordArray){
    char[] _vowelArr = {'a', 'e', 'i', 'o', 'u'};
    int _countVowels = 0;
    int _wordVowelNum = 0;
    for(int i = 0; i < _wordArray.Length; i++){
        for(int k = 0; k < _vowelArr.Length; k++){
            if(_wordArray[i][_wordVowelNum] == _vowelArr[k]){
                _countVowels++;
                break;
            }
        }
    }

    return _countVowels;
}

string[] wordArr = { "owe", "ter", "trt", "rty", "ayu"};


Console.WriteLine();

Console.WriteLine($"{ShowArray(wordArr)} -> {CaclulateVowels(wordArr)}");
*/
/* Задача 2. Описание.
Задача 2: Задайте массив строк. Напишите программу,
которая генерирует новый массив, объединяя элементы исходного массива попарно.

Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
*/
/* Задача 2. Решение.
string ShowArray(string[] _array){
    string _result = string.Empty;
    
    _result += "{ ";
    for(int i = 0; i < _array.Length; i++)
        _result += ($"\"{_array[i]}\", ");
    _result =_result.Substring(0,_result.Length - 2);
    _result += " }";

    return _result;
}

string[] ArrangeToPairs(string[] _array){
    string[] _pairsArray = new string[_array.Length / 2];
    for(int i = 0; i < _pairsArray.Length; i++)
        _pairsArray[i] = _array[2 * i] + _array[2 * i + 1];

    return _pairsArray;
}

string[] wordArr = { "qwe", "wer", "ert", "rty", "tyu", "yui"};

Console.WriteLine();

Console.WriteLine($"{ShowArray(wordArr)} -> {ShowArray(ArrangeToPairs(wordArr))}");
*/