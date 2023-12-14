//See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.Design;
using System.Xml.Linq;

int number = 12345;
int l0 = 0; 
int l1 = 0; 
int l2 = 0;
int l3 = 0;
int l4 = 0;
int l5 = 0;
int l6 = 0;
int l7 = 0;
int l8 = 0;
int l9 = 0;


string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

    foreach (char c in letters)
    {
    if (c == '0')
    {
        l0 = l0 + 1;
    }
    if (c == '1')
    {
        l1 = l1 + 1;
    }
    if (c == '2')
    {
        l2 = l2 + 1;
    }
    if (c == '3')
    {
        l3 = l3 + 1;
    }
    if (c == '4')
    {
        l4 = l4 + 1;
    }
    if (c == '5')
    {
        l5 = l5 + 1;
    }
    if (c == '6')
    {
        l6 = l6 + 1;
    }
    if (c == '7')
    {
        l7 = l7 + 1;
    }
    if (c == '8')
    {
        l8 = l8 + 1;
    }
    if (c == '9')
    {
        l9 = l9 + 1;
    }
}

Console.Write("Wyniki dla liczby: ");
Console.WriteLine(number);

Console.Write(" 0 => ");
Console.WriteLine(l0);

Console.Write(" 1 => ");
Console.WriteLine(l1);

Console.Write(" 2 => ");
Console.WriteLine(l2);

Console.Write(" 3 => ");
Console.WriteLine(l3);

Console.Write(" 4 => ");
Console.WriteLine(l4);

Console.Write(" 5 => ");
Console.WriteLine(l5);

Console.Write(" 6 => ");
Console.WriteLine(l6);

Console.Write(" 7 => ");
Console.WriteLine(l7);

Console.Write(" 8 => ");
Console.WriteLine(l8);

Console.Write(" 9 => ");
Console.WriteLine(l9);

