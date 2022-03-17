using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationApp
{
    class PopulationApp
    {
        static void Main(string[] args)
        {

            Population Population = new Population();
            int[] Year = new int[2];
            int[] Populations = new int[2];
            Console.WriteLine("Please Enter the country name :");
            Population.CountryName = Console.ReadLine();
            Console.Write("Please Enter the Start year : ");
            Year[0] = Convert.ToInt32(Console.ReadLine());
            Population.Year[0] = Year[0];

            int count = 2;

            for (int x = 1; x < Year.Length; x++)
            {

                //count = count + 1;
                Console.Write("Please Enter year " + count + " : ");
                Year[x] = Convert.ToInt32(Console.ReadLine());
                Population.Year[x] = Year[x];

                count = count + 1;

            }
            Console.WriteLine("Please Enter start year Population :");
            Populations[0] = Convert.ToInt32(Console.ReadLine());
            Population.Populations[0] = Populations[0];

            int counter1 = 2;
            for (int y = 1; y < Year.Length; y++)
            {



                Console.WriteLine("Please Enter year " + counter1 + " Population :");
                Populations[y] = Convert.ToInt32(Console.ReadLine());
                Population.Populations[y] = Populations[y];

                counter1 = counter1 + 1;

            }

            Console.WriteLine("Country Name : " + Population.CountryName);
            Console.WriteLine("Year \tPopulation");
            for (int w = 0; w < Year.Length; w++)
            {
                

                Console.WriteLine(Year[w] + "\t " + Populations[w]);
                
            }
            Console.WriteLine("The average population Between the years is " + Population.CalcAverage());

            Population.HighestPopulation();
            Population.LowestPopulation();

            Console.ReadLine();




        }
    }
}
