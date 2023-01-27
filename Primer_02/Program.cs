//   Пишем через цикл FOR

string Method4(int count, string c) // возвращать будем строку тип данных !!char!! Считывает один символ, он может быть пробел или символ конца строки.
{
    // будем строку "С" компоновать друг за дружкой компоновать count раз
     //        string result = "" -  лежит пустая строка или написать String.Empty
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result; // указываем ту переменную которую мы хотим получить из метода
}

/// вызов метода 4
string res = Method4(10, "Cdtn");
System.Console.WriteLine(res);
