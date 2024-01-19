using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class DiceRoller
    {
        public static int[] RollSimulator(int numRolls)
        {
            // Array with 13 positions to account for the max number of 2 dice (12) even with the poistions of 0 and 1 being n/a
            int[] results = new int[13];

            //Instance of the class random
            Random rand = new Random();

            //create a for loop that selects a random number for each die
            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = rand.Next(1, 7);
                int dice2 = rand.Next(1, 7);
                int sum = dice1 + dice2;

                results[sum]++;
            }
            return results;

        }

    } 
}
