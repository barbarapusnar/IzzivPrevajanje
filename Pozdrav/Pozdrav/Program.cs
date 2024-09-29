using System.IO;
namespace Pozdrav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pozdrav = "Kako si kaj danes?";
            string filePath = "./a.txt";
            // Zapiši datoteko
            File.WriteAllText(filePath, pozdrav);
        }
    }
}
