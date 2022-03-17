using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationApp
{
    class Population
    {

        public String CountryName { get; set; }
        public int[] Year = new int[2];
        public int[] Populations = new int[100];
        public int Average { get; }
        public int Highest { get; }
        public int Lowest { get; }

        public int CalcAverage()
        {
            int average = 0;

            for (int x = 0; x < Year.Length; x++)
            {

                average = average + Populations[x];

            }
            average = average / Year.Length ;

            return average;
        }

        public void HighestPopulation()
        {
            int Highest1 = 0;
            int Highest = 0;
            int value = 0;

            for (int y = 0; y < Year.Length; y++)
            {

                if (Populations[y] > Highest)
                {

                    Highest = Populations[y];
                    value = y;
                }

            }
            Highest1 = Highest;
            Console.WriteLine("Year with highest population is :" + Year[value] + " with a Populate of " + Highest1);
        }


        public void LowestPopulation()
        {

            int Lowest1 = 0;
            int Lowest = 0;
            int index = 0;
            int Point = 0;
            for (int x = 0; x < Year.Length; x++)
            {
                if (Populations[x] < Lowest)
                {

                    Lowest = Populations[x];
                    index = x;
                }

            }
            Lowest1 = Lowest;
            Point = index;
            Console.WriteLine("Year with lowest population is :" + Year[Point] + " with a Population of " + Lowest1);
        }






    }
}
