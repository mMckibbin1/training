using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationTask
{
    class Program
    {
        public static string[] calculations;
        static Random rnd = new Random();
        public static int NoCalculation = 6;
        
        static void Main(string[] args)
        {
            calculations = new string[NoCalculation];

            for(int i = 0; i < NoCalculation; i++)
            {
                int no1, no2, ans;

                no1 = Random;

                no2 = Random;

                if (no1 > 50)
                {
                    ans = no1 - no2;

                    calculations[i] = no1.ToString() + "-" + no2.ToString() + "=" + ans.ToString();
                }
                else if (no1 > 100)
                {
                    ans = no1 + no2;

                    calculations[i] = no1.ToString() + "+" + no2.ToString() + "=" + ans.ToString();
                }                    
                else
                {
                    ans = no1 * no2;

                    calculations[i] = no1.ToString() + "*" + no2.ToString() + "=" + ans.ToString();
                }
                   
                Console.WriteLine(ans);
            }


            for (int i = 0; i < NoCalculation; i++)
            {
                string ans;

                do
                {
                    Console.WriteLine("\nType the equation for no) " + (i + 1));

                    ans = Console.ReadLine();

                } while (ans != calculations[i]);
            }

            Console.WriteLine("\nCongratulations =) You've completed the exercise");
            Console.ReadLine();
        }

        public static int Random
        {
            get { return rnd.Next(1, 201); }
        }
    }
}
