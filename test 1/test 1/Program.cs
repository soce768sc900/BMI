using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("(=￣ω￣=)(=￣ω￣=)(=￣ω￣=)(=￣ω￣=)(=￣ω￣=)");
            Console.WriteLine("(=￣ω￣=)                              (=￣ω￣=)");
            Console.WriteLine("(=￣ω￣=)                              (=￣ω￣=)");
            Console.WriteLine("(=￣ω￣=)             BMI              (=￣ω￣=)");
            Console.WriteLine("(=￣ω￣=)                              (=￣ω￣=)");
            Console.WriteLine("(=￣ω￣=)                              (=￣ω￣=)");
            Console.WriteLine("(=￣ω￣=)(=￣ω￣=)(=￣ω￣=)(=￣ω￣=)(=￣ω￣=)");

            Console.WriteLine("請輸入體重:");
            string input = Console.ReadLine();
           
          Console.WriteLine("請輸入身高(公尺):");
            string output = Console.ReadLine();

            double w = double.Parse(input);
            double h = double.Parse(output);
            double bmi = w / (h * h);

            Console.WriteLine("您的BMI="+ bmi);

            if (bmi > 24) {
                Console.WriteLine("你要減肥囉!");
            }
            else if (bmi < 18.5)
            {
                Console.WriteLine("你要多吃一點東西喔!");

            }
            else
            {
                Console.WriteLine("身材很好喔,剛剛好!!!");
            }
            Console.ReadLine();
            //Console.Beep(1000, 2000);
            //double num= 29.3;

            //Console.WriteLine("請輸入金額:");
            //string input= Console.ReadLine();



        }
    }
}
