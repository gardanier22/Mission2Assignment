using Mission2Assignment;
using System.ComponentModel.Design;

internal class DiceSimulator
{
    private static void Main(string[] args)
    {
        // Welcome message to the dice throwing simulator and how many times they wanna roll the dice
        System.Console.WriteLine("Welcome message to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to take?");

        // Positive integer check
        string number = System.Console.ReadLine();
        if (int.TryParse(number, out int numberOfRolls) && numberOfRolls > 0)
        {
            int[] myResults = DiceRoller.RollSimulator(numberOfRolls);

            System.Console.WriteLine("\nDice Roll Results");
            System.Console.WriteLine("Total number of rolls: " + numberOfRolls);

            //start at 2 because we have two dice and the lowest number we can have between the 2 dice is 2
            // for loop cycles through positions in the array to see how many times each combination occured
            for (int i = 2; i <= 12; i++)
            {
                int percentage = myResults[i] * 100 / numberOfRolls;
                System.Console.WriteLine(i + ": " + new string('*', percentage));
            }

            System.Console.WriteLine("\nThanks for playing!");
            
        }
        else
        {
            // in the case they enter in not a valid number
            System.Console.WriteLine("Invalid Input! Please enter a valid input.");
        }
    }
}