using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToCsv
{
    class Program
    {


        static void Main(string[] args)
        {
            string[,] files = new string[2, 5];
            files[0, 0] = "Hii";
            files[0, 1] = "this";
            files[0, 2] = "Pradeep";
            files[0, 3] = "Softwaredeveloper";
            files[0, 4] = "RIT";

            files[1, 0] = "King";
            files[1, 1] = "43";
            files[1, 2] = "76";
            files[1, 3] = "bangalore";
            files[1, 4] = "6533108";

            StreamWriter sw = File.CreateText("OutputText.csv");
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 5; j++)
                {
                    sw.Write(files[i, j] + ";");

                }

                sw.Write("\n");

            }

            sw.Flush();
            sw.Close();
            Console.WriteLine("success");







        }
    }
}
