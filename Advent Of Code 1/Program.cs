using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Advent_Of_Code_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            List<int> elfi = new List<int>();
            string line = sr.ReadLine();
            int add = 0;
            //When the reader sees the file is empty it exits the while
            while (line != null)
            {
                if (line == "")
                {
                    elfi.Add(add);
                    add = 0;
                    line = sr.ReadLine();
                    continue;
                }
                add += Convert.ToInt32(line);
                line = sr.ReadLine();
            }
            //Could have done a better job not using sort, but I'm lazy
            //(If you fix this the program would be faster)
            elfi.Sort();
            Console.WriteLine(elfi[elfi.Count - 1]);
            sr.Close();

            //Just so that the program doesn't close
            Console.ReadKey();
        }
    }
}
