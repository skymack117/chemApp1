using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace chemicalApp
{

    internal class Program
    {

        //globel vearabals
        int TimesRun = 0;

        //lists

        static void Main(string[] args)
        {
            //gen ran num of germs in sampil

            Random randomnumber = new Random();
            int germs = randomnumber.Next(5000, 10000);
            Console.WriteLine($"There are {germs} grems in this sample");
            Console.ReadLine();

            
            int chemE = 0;
            for (int TimesRun = 0; TimesRun <= 5
                ; TimesRun++)
            {
                //chemical efincy rating
                chemE = randomnumber.Next(5000, germs);

                
            }
               

            //chemical list


            Console.WriteLine(" 1| Hypochlorite (Bleach) \n 2| Alcohols \n 3| Chlorine Dioxide \n 4| Hydrogen Peroxide \n 5| Iodophor Disinfectant\n\n");
            Console.WriteLine("plz enter a the number that the chemical you want to test is asind to\n");
            int UserImput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n10 seconds later...");


            
            //Hypochlorite (Bleach) calculaion
            if (UserImput.Equals(1))
            {

                Console.WriteLine("\nyou have chosin Hypochlorite (Bleach)");

                Console.WriteLine($"in this test Bleach killed {chemE} of the {germs} germs in the sampil");

                Console.WriteLine("this will now repet 4 more times");

               


                Console.ReadLine();




            }


            //alcohol
            else if (UserImput.Equals(2))
            {
                Console.WriteLine("\nyou have chosin Alcohol");

                Console.WriteLine($"in this test Alcohol killed {chemE} of the {germs} germs in the sampil");

                Console.ReadLine();

            }


            //Chlorine Dioxide
            else if (UserImput.Equals(3))
            {
                Console.WriteLine("\nyou have chosin Chlorine Dioxide");

                Console.WriteLine($"in this test Chlorine Dioxide killed {chemE} of the {germs} germs in the sampil");

                Console.ReadLine();
            }


            //Hydrogen Peroxide
            else if (UserImput.Equals(4))
            {
                Console.WriteLine("\nyou have chosin Hydrogen Peroxide");

                Console.WriteLine($"in this test Hydrogen Peroxide killed {chemE} of the {germs} germs in the sampil");

                Console.ReadLine();
            }

            //Iodophor Disinfectant
            else if (UserImput.Equals(5))
            {
                Console.WriteLine("\nyou have chosin Iodophor Disinfectant");

                Console.WriteLine($"in this test Iodophor Disinfectant killed {chemE} of the {germs} germs in the sampil");



                Console.ReadLine();
            }





        }



    }

}