// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа.



string[] Array = new string[5] {"window", "89", "1", "846352", "764"}; // Задаем массив из строк

string[] CountAndResultArray(string[] Array, int countOfSymbols) // Создаем метод, который будет считать кол-во символов в слове и выдаст результирующий массив строк
{
    int[] defineQuantityOfSymbols = new int[Array.Length]; // создаем массив целых чисел для запоминания индекса слова с нужным кол-м символов
    
    int count = 0; 
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i].Length <= countOfSymbols)
        {
                defineQuantityOfSymbols[count] = i;
                count++;    
        }
    }

    string[] newArray = new string[count]; // Создаем результирующий массив строк, используя результат предыдущего блока кода
    for(int i = 0; i < count; i++)
    {
        newArray[i] = Array[defineQuantityOfSymbols[i]];
    }
    return newArray;
}


string[] Array2 = new string[5] {"1", "Ok", "timeless", "93820183746", "run"}; 
Console.WriteLine($"[{string.Join(", ", Array2)}] -> [{string.Join(", ", CountAndResultArray(Array2, 3))}]"); // вызываем метод и задаем кол-во симоволов для слова =3.

string[] Array3 = new string[5] {"Divan", "vaza", "93", "Ika", "uha"};
Console.WriteLine($"[{string.Join(", ", Array3)}] -> [{string.Join(", ", CountAndResultArray(Array3, 2))}]"); // вызываем метод и задаем кол-во симоволов для слова =2.

string[] Array4 = new string[3] {"7", "5", "juke"};
Console.WriteLine($"[{string.Join(", ", Array4)}] -> [{string.Join(", ", CountAndResultArray(Array4, 1))}]"); // вызываем метод и задаем кол-во симоволов для слова =1.