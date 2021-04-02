using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            Console.WriteLine(Add(num1, num2));
        }
        static string Add(string num1, string num2)
        {
          
            if (num1.Length > num2.Length)
            {
                string t = num1;
                num1 = num2;
                num2 = t;
            }

            
            string str = "";

            int n1 = num1.Length, n2 = num2.Length;

           
            char[] ch = num1.ToCharArray();
            Array.Reverse(ch);
            num1 = new string(ch);
            char[] ch1 = num2.ToCharArray();
            Array.Reverse(ch1);
            num2 = new string(ch1);

            int cc = 0;
            for (int i = 0; i < n1; i++)
            {
                
                int sum = ((int)(num1[i] - '0') +
                        (int)(num2[i] - '0') + cc);
                str += (char)(sum % 10 + '0');

                cc = sum / 10;
            }

            
            for (int i = n1; i < n2; i++)
            {
                int sum = ((int)(num2[i] - '0') + cc);
                str += (char)(sum % 10 + '0');
                cc = sum / 10;
            }

           
            if (cc > 0)
                str += (char)(cc + '0');

            
            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            str = new string(ch2);

            return str;
        }
    }
}
