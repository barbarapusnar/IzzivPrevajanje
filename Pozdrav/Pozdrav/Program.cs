using System.IO;
namespace Pozdrav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pozdrav = "Kako si kaj?";
            string filePath = "./izhod/a.txt";
            // Zapiši datoteko
            File.WriteAllText(filePath, pozdrav);
            Console.WriteLine($"Datoteka ustvarjena na poti: {filePath}");

        }
    }
}
