using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string iDate = date.ToString();
            
            DateTime oDate = Convert.ToDateTime(iDate);
            // Console.WriteLine(oDate.Day + " " + oDate.Month + "  " + oDate.Year );
            int y = Convert.ToInt32(oDate.Year);
            Console.WriteLine(y);
            int t =0;
            if(y%4==0){
                if(y%100==0)
                {
                    if(y%400==0)
                    {
                        t= 1;
                    }
                }
                else{
                    t =1;
                }
            }
            else {
                 t =0;
            }
            if(t==1)
            Console.WriteLine("This is a leap year");
                
            else
                Console.WriteLine("This is not a leap year");
        }

    }
}
