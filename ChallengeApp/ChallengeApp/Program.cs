// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.ComponentModel.Design;
using System.Xml.Linq;
string plec = "Kobieta";
bool isActive = true;
isActive = false;
string name = "Ewa";
int age = 17;

if (plec == ("Kobieta") && name == ("Ewa") && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else
{
    if (name != ("Ewa") && age > 30)
    {

        Console.WriteLine("Kobieta powyżej 30 lat");
    }
    else
    {
        if (plec != ("Kobieta") && age < 18)
        {
            Console.WriteLine("Niepelnoletni mezczyzna");
        }
        else
        {
            Console.WriteLine("Niespelniony zaden z warunków");
        }
    }
}
