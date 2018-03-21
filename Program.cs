using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hexasoft.Zxcvbn;


namespace Zxcvbn_Password_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();
            Console.WriteLine("____________________\n\n");


            var estimator = new ZxcvbnEstimator();
            var result = estimator.EstimateStrength(password);

            Console.WriteLine(result.Password);
            Console.WriteLine("____________________\n\n");
            Console.WriteLine(result.Score);
            Console.WriteLine(result.CalcTime);
            //Console.WriteLine(result.CrackTimesDisplay);
            //Console.WriteLine(result.CrackTimesSeconds);
            Console.WriteLine(result.Feedback);
            Console.WriteLine(result.Guesses);
            Console.WriteLine(result.GuessesLog10);
            Console.WriteLine(result.Sequence);


            if (result.Score < 3)
            {
                Console.WriteLine("Password is not strong enough");
                Console.WriteLine(result.Feedback.Warning);
                Console.WriteLine(string.Join(Environment.NewLine, result.Feedback.Suggestions));
            }

            Console.ReadKey();
        }
    }
}
