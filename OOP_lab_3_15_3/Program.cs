using System;
using System.IO;

namespace OOP_lab_3_15_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fromFile = new StreamReader("input.txt");

            string str = fromFile.ReadToEnd();

            string[] words = str.Split(new char[] { ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*' }, StringSplitOptions.RemoveEmptyEntries);

            StreamWriter toFile = File.CreateText("output.txt");

            toFile.WriteLine(words.Length);

            fromFile.Close();

            toFile.Close();
        }
    }
}
