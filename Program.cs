using System;
using System.IO;


namespace ReplyChallenge
{
    class program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Reply Challenge 2019!");
        }
        static string generateOneLine(int x, int y, string line){
            return x.ToString()+" "+y.ToString()+" "+line.ToString();
        }
        
        /*we need a function here to generateAllLines */
        static bool generateOutput(string[] lines){
            if(System.IO.File.Exists(@"./output/output.txt"))
                System.IO.File.Delete(@"./output/output.txt");
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"./output/output.txt"))
                foreach (string line in lines){
                    file.WriteLine(line);
                }
            return true;
        }
    }
}