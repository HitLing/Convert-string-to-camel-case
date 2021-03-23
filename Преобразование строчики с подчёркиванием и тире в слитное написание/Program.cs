using System;
using System.Collections.Generic;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        char[] newStr = str.ToCharArray();
        string SafeNextLetter;
        int maxlength = str.Length;
        for (int i = 0; i< maxlength; i++) {
            if ((newStr[i] == Convert.ToChar("-")) || (newStr[i] == Convert.ToChar("_"))) {
                SafeNextLetter = newStr[i + 1];
                newStr[i] = Convert.ToChar(SafeNextLetter.ToUpper);
                for (int j = i+1;j< maxlength; j++) {
                    newStr[j] = newStr[j + 1];
                }
                var overloading = new List(newStr);
                overloading.RemoveAt(maxlength);
                maxlength = maxlength - 1;
                char[] newStr = overloading.ToArray;
            }
        }
        return str;
    }
}


/*public class Kata { 
    public static string ToCamelCase(string str) 
    {
        char SafeLetter;
        char[] newStr = str.ToCharArray();
        int maxlength = str.Length;
        char overloading = new List(newStr);
        for (int i = 0; i < maxlength; i++)
        {
            if (overloading<i> == Convert.ToChar("-")) || (newStr[i] == Convert.ToChar("_"))) {

            }
        }*/




namespace Преобразование_строчики_с_подчёркиванием_и_тире_в_слитное_написание
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.ToCamelCase("the-stealth-warrior");
           
        }
    }
}
