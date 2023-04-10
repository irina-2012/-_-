
using System;
using static System.Console;

Clear();
Write("Введите значения массива через пробел: ");
string[] array = ReadLine().Split(" ");
string[] array2 = NewArray(array);
WriteLine($"[{String.Join(" ",array)}] -> [{String.Join(" ",array2)}]");
string[] NewArray (string[] mas)
{

    string[] newArray = new string [mas.Length];
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i].Length <=3)
        {
            newArray[i]= mas[i];
        }
    }return newArray;
}

