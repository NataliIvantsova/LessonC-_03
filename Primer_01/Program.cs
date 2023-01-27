// // Группа методов 1 
//void Method1() 
// {
//     System.Console.WriteLine("Privet.....");
// }
// вызов метода Method1();


// Группа методов 2

// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2("Текст сообщения"); или Method2(msg: "Текст сообщения")


// void Method21(string msg, int schet)// счет необходим для того чтобы сообщение вывести несколько раз
// {
//     int i = 0;
//     while (i < schet)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method21("Текст сообщения", 4); // выввести текст сообщения 4 раза
// //Method21(msg: "Текст сообщения",schet: 4); // вызов через именование типа переменных
// Method21(schet: 4, msg: "Текст сообщения"); // вызов через именование типа переменных так тоже верно

// Группа методов 3

// int Method3()
// {
//     return DateTime.Now.Year;// вывод текущего года. здесь происходит работа
// }
// int year = Method3(); //сюда будет положен результат метода- работы
// System.Console.WriteLine(year);//

// Группа методов 4

string Method4(int count, string c) // возвращать будем строку тип данных !!char!! Считывает один символ, он может быть пробел или символ конца строки.
{
    int i = 1; // будем строку "С" компоновать друг за дружкой компоновать count раз
               //        string result = "" -  лежит пустая строка или написать String.Empty
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
return result; // указываем ту переменную которую мы хотим получить из метода
}

           /// вызов метода 4
string res = Method4(10,"Cdtn");
System.Console.WriteLine(res);
