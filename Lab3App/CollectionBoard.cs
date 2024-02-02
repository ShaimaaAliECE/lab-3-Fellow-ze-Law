using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class CollectionBoard
    {
        // Here, set the total score and total value.
        public int TotalScore { get; private set; }
        public int TotalValue { get; private set; }

        // For both score and value, just use "+=" to make it continuously increasing.
        public void UpdateTotalScore(int score)
        {
            TotalScore += score;
            Console.WriteLine($"Total Score is updated to: {TotalScore}");
        }

        public void UpdateTotalValue(int value)
        {
            TotalValue += value;
            Console.WriteLine($"Total Value is updated to: {TotalValue}");
        }
    }
}
