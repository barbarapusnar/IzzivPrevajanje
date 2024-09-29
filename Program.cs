// See https://aka.ms/new-console-template for more information
using System.IO;
var filePath = Path.Combine(Directory.GetCurrentDirectory(), "a.txt");
File.WriteAllText(filePath, "Dobro jutro");
System.Console.WriteLine("Napisano");
