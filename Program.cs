// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
var currentDir = Directory.GetCurrentDirectory();
Console.WriteLine($"Current Directory: {currentDir}");
DirectoryInfo d=new DirectoryInfo(currentDir);
DirectoryInfo d1=new DirectoryInfo(Path.Combine(currentDir,"dat"));
if (!d1.Exists)
{
   d1= d.CreateSubdirectory("dat");
}

var filePath = Path.Combine(d1.FullName, "a.txt");
StreamWriter sw=new StreamWriter(filePath);
sw.WriteLine("Dobro jutro");
sw.Close();
Console.WriteLine($"File created: {filePath}");