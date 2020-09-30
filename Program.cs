using System;
using System.IO;


namespace ReplyChallenge
{
    class program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Reply Challenge 2019!");
            string[] lines = { "test 1", "test2", "jsp" };
            System.Console.WriteLine(generateOutput(lines));
        }
        /* string generateOneLine(int x, int y, string line){
            string line=x.ToString()+" "+y.ToString()+" "+line.ToString();
            return line;
        } */
        
        static bool generateOutput(string[] lines){
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"./output/output.txt"))
                foreach (string line in lines){
                    file.WriteLine(line);
                }
            return true;
        }
    }
}