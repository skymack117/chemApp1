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
        int TimesRun = 1;


        //lists

        static int checkChem()
        {
            while (true)
            {
                //chemical list
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"        __                   _            _____" + "\n" +
                                  @"  _____/ /_  ___  ____ ___  (_)________ _/ /   |  ____  ____" + "\n" +
                                  @" / ___/ __ \/ _ \/ __ `__ \/ / ___/ __ `/ / /| | / __ \/ __ \" + "\n" +
                                  @"/ /__/ / / /  __/ / / / / / / /__/ /_/ / / ___ |/ /_/ / /_/ /" + "\n" +
                                  @"\___/_/ /_/\___/_/ /_/ /_/_/\___/\__,_/_/_/  |_/ .___/ .___/" + "\n" +
                                  @"                                              /_/   /_/" + "\n");
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("---------------------------------------------------------------");

                Console.WriteLine("Hi there, this is chemicalApp and he is here to help!\nHe can calculate the efficiency of various cleaning chemicals.\n                         Enjoy! ");

                Console.WriteLine("---------------------------------------------------------------\n");

                Console.WriteLine(" 1| Hypochlorite (Bleach) \n 2| Alcohols \n 3| Chlorine Dioxide \n 4| Hydrogen Peroxide \n 5| Iodophor Disinfectant\n\n");
                Console.WriteLine("plz enter a the number that the chemical you want to test is assigned to\n");
                







                int UserImput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (UserImput >= 1 && UserImput <= 5)
                {
                    
                    return UserImput;

               
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                Console.WriteLine("ERROR plz enter a number between 1 and 5 thank you\n");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }
        static void chemicalApp()
        {
            int chosinChem = checkChem();  
            //gen ran num of germs in sampil

            Random randomnumber = new Random();
            int germs = randomnumber.Next(5000, 10000);
            Console.WriteLine($"There are {germs} grems in this sample");
            Console.ReadLine();



            int TimesRun = 1;
            int chemE = 0;
            chemE = randomnumber.Next(0, germs);



            //Hypochlorite (Bleach) calculaion
            if (chosinChem.Equals(1))
            {


                Console.WriteLine("\nyou have chosin Hypochlorite (Bleach)");
                Console.WriteLine("\n10 seconds later...");
                Console.WriteLine($"\nreminder there are {germs} germs in this sampill");
                Console.WriteLine("here are the five resolts");

                Console.ReadLine();

            }


            //alcohol
            else if (chosinChem.Equals(2))
            {
                Console.WriteLine("\nyou have chosin Alcohol");
                Console.WriteLine("\n10 seconds later...");
                Console.WriteLine($"\nreminder there are {germs} germs in this sampill");
                Console.WriteLine("here are the five resolts");

                Console.ReadLine();

            }


            //Chlorine Dioxide
            else if (chosinChem.Equals(3))
            {
                Console.WriteLine("\nyou have chosin Chlorine Dioxide");
                Console.WriteLine("\n10 seconds later...");
                Console.WriteLine($"\nreminder there are {germs} germs in this sampill");
                Console.WriteLine("here are the five resolts");

                Console.ReadLine();
            }

            //Hydrogen Peroxide
            else if (chosinChem.Equals(4))
            {
                Console.WriteLine("\nyou have chosin Hydrogen Peroxide");
                Console.WriteLine("\n10 seconds later...");
                Console.WriteLine($"\nreminder there are {germs} germs in this sampill");
                Console.WriteLine("here are the five resolts");

                Console.ReadLine();
            }

            //Iodophor Disinfectant
            else if (chosinChem.Equals(5))
            {
                Console.WriteLine("\nyou have chosin Iodophor Disinfectant");
                Console.WriteLine("\n10 seconds later...");
                Console.WriteLine($"\nreminder there are {germs} germs in this sampill");
                Console.WriteLine("here are the five resolts");

                Console.ReadLine();
            }
            



            // times run conter
            for (TimesRun = 1; TimesRun <= 5
                ; TimesRun++)
            {
                //chemical efincy rating
                chemE = randomnumber.Next(5000, germs);
                Console.WriteLine($"|{TimesRun}| chemical Efish = {chemE}");
            }
            

        } 
            //main while loop
            static void Main(string[] args)
            {
            
            string flag = "";
            
            while (!flag.Equals("stop"))
                {
                    chemicalApp();
                    
                    Console.WriteLine("press Enter to add another chemical or type 'Stop' to end the program\n");
                    flag = Console.ReadLine();

                    Console.Clear();
                }

            }

        }

}