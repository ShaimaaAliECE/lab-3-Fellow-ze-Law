using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Diamond : Treasure
    {
        // Diamond.cs is easier to write than Coin.cs, that is because here only need count score and display it.
        public Diamond(string description, int score) : base(description)
        {
            Score = score;
            // Inside the constructor, define the score.
        }

        public int Score { get; }
        // Score getter...

        public override void Display()
        {
            Console.WriteLine($"Diamond {Description} is displayed");
            // Call this as display message in the end.
        }

        public override void UpdateTotalScore()
        {
            Board?.UpdateTotalScore(Score);
            // Update the total score here, then override in Treasure.cs.
        }
    }
}
