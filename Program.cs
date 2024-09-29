// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
var currentDir = Directory.GetCurrentDirectory();
Console.WriteLine($"Current Directory: {currentDir}");
var filePath = Path.Combine(currentDir, "a.txt");
File.WriteAllText(filePath, "Dobro jutro");
Console.WriteLine($"File created: {filePath}");