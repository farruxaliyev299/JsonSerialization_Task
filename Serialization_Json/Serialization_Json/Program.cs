using System;
using System.IO;

namespace Serialization_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"C:\Users\DELL\Desktop\Code Academy\Json\NewDirectory");
            //File.Create(@"C:\Users\DELL\Desktop\Code Academy\Json\NewDirectory\newfile.txt");

            using (StreamWriter sw = new StreamWriter(@"C:\Users\DELL\Desktop\Code Academy\Json\NewDirectory\newfile.txt"))
            {
                sw.Write("Test, ");
                sw.WriteLine("Text.");
            }

            string result;

            using (StreamReader sr = new StreamReader(@"C:\Users\DELL\Desktop\Code Academy\Json\NewDirectory\newfile.txt"))
            {
                result = sr.ReadToEnd();
            }

            Console.WriteLine(result);

        }
    }
}
