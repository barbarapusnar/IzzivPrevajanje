using System.IO;
namespace Pozdrav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pozdrav = "Kako si kaj?";
            StreamWriter sw=new StreamWriter("a1.txt");
            sw.WriteLine(pozdrav);
            sw.Close();
            Console.WriteLine(pozdrav);
        }
    }
}
