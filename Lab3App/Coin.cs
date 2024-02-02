using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure
    {
        private bool printTotalValue = false;
        // Again, set a boolean algebra here to decide whether should print the total value, so initally set it false to not display.

        public Coin(string description, int score, int value) : base(description)
        {
            // Inside the constructor, define score, value, and set IsCoin to be true for Collectable.cs to make my process works.
            Score = score;
            Value = value;
            IsCoin = true;
        }

        // Getter for score and value.
        public int Score { get; }
        public int Value { get; }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
            // Call this as display message in the end.
        }

        public override void UpdateTotalScore()
        {
            Board?.UpdateTotalScore(Score);
            // Update the score, as usual calling method.
        }

        public override void UpdateTotalValue()
        {
            // Make sure this method is only true for coins, others are false.
            if (!printTotalValue)
            {
                Board?.UpdateTotalValue(Value);
                // Then, we override the total value.
                printTotalValue = true;
                // Set it true to display the output of total value in CollectionBoard.cs.
            }
        }
    }
}
