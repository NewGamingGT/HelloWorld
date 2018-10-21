using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            int MaxN = ReadNum("How many row of * do you want to print?");

            #region My commented code
            //int MaxColumn = ReadNum("How many Colum of * do you want to print?");
            #endregion

            for (int n = 1; n <= MaxN; n++)
            {
                PrintSpace(MaxN-n);
                PrintRow(2*n-1,n);
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        #region My Helper Functions

        static void PrintSpace(int num)
        {
            for (int indexOfColum = 1; indexOfColum <= num; indexOfColum++)
            {
                Console.Write("   ");
            }
        }
        static void PrintRow(int num, int numToPrint)
        {
            for (int indexOfColum = 1; indexOfColum <= num; indexOfColum++)
            {
                if (numToPrint < 10)
                {
                    Console.Write(" ");
                }
                Console.Write(numToPrint + " ");
            }
        }

        static int ReadNum(string prompt)
        {
            Console.Clear();
            Console.WriteLine(prompt);
            string readString = Console.ReadLine();
            if (!string.IsNullOrEmpty(readString))
            {
                int num = int.Parse(readString);
                return num;
            }
            return 0;
        }

        // ***also dllimport of that function***
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();


        #endregion
    }
}
