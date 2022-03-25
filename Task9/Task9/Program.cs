using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin");
            string numstr1 = Console.ReadLine();
            Console.WriteLine("Ikinci ededi daxil edin");
            string numstr2 = Console.ReadLine();

            Console.WriteLine("Ucuncu ededi daxil edin");
            string numstr3 = Console.ReadLine();
            if (numstr1.Length+1>=6 && numstr2.Length + 1 >= 6 && numstr3.Length + 1 >= 6 )
            {
                //parsing to int32
                int numint1 = int.Parse(numstr1);
                int numint2 = int.Parse(numstr2);
                int numint3 = int.Parse(numstr3);
                //Persentage to 10 for all numbers
                double numint1perc1 = numint1 * 0.1; 
                double numint2perc1 = numint2 * 0.1; 
                double numint3perc1 = numint3 * 0.1;
                //Summary for all numbers for 10%
                double resultsum = numint1perc1 + numint2perc1 + numint3perc1;
                //All sum 10% method
                double resultfinal = resultsum * 0.1;
                Console.WriteLine("-------");
                Console.WriteLine("Netice :");
                Console.WriteLine(resultfinal);
                
            }
            else
            {
                Console.WriteLine("Xais olunur sertlere uygun eded daxil edin!!");
            }

        }
    }
}
