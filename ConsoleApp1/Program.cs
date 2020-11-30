using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //NameChecker();
            SumofTwoNumber();
        }

        public static void NameChecker()
        {
            try
            {
                Console.WriteLine("Please enter a name to check");
                string name = Console.ReadLine();
                char[] names = new char[name.Length];
                string removesEM = "";


                for (int i = 0; i < name.Length; i++)
                {
                    names[i] = name[i];
                }
                if (names.Contains<char>('s') && names.Contains<char>('a'))
                {
                    //string removesEM;
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names.Contains<char>('e') || names.Contains<char>('m'))
                        {

                            removesEM = names.ToString();
                            string removesEMs = removesEM.Replace("e", " ");
                            removesEMs = removesEM.Replace("m", " ");
                            int countedLetters = removesEM.Count<char>();

                            Console.WriteLine("You entered the word {0}, and it has letters \"s" + " and " + "\"a\"", name);
                            Console.WriteLine(" and we have removed all instances of e and m, the remaining word is {0} and the count is {1} ", removesEMs, countedLetters);
                            Console.ReadLine();

                        }

                    }

                }
                else
                {
                    Console.WriteLine("The name you entered does not contain the letters  \"s\" " + "and" + "\"a\"");
                    Console.ReadLine();
                }

            }
            catch (Exception)

            {

                throw;
            }
        }

        public static int SumofTwoNumber()
        {

            int num1 = 0;
            int num2 = 0;
            int sum;
            
            Console.WriteLine("Enter your firstnumber");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;

            if (sum == 30)
            {
                Console.WriteLine("The sum of the two numbers you entered is {0}", sum);
               
            }
            if (sum > 30)
            {
                Console.WriteLine("The sum of the two numbers you entered is greater than 30 ");
            }
            else if (sum < 30)
            {
                Console.WriteLine("The sum of the two numbers you entered does not add up to 30");
            }
           
            Console.ReadLine();
            return sum;
        }
    }
}
