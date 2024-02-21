using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string svar = Console.ReadLine();
        Console.WriteLine("Det finns "+AntalTallText(svar)+" stycken tal i den meningen");
    }
    static int AntalTallText(string text)
    {
        int gånger =0;
        string[] ord = text.Split(' ');
        for (int i = 0; i < ord.Length; i++)
        {
            try
            {
                double test = double.Parse(ord[i]);
                gånger++;
            }
            catch
            {

            }
        }
        return gånger;
    }
}