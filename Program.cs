// See https://aka.ms/new-console-template for more information
using System.IO;
string pot="a.txt";
string sporočilo="Dobro jutro";
File.WriteAllText(pot,sporočilo);
System.Console.WriteLine("Napisano");
