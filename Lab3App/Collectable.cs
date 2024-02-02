using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        private static bool displayMessage = false;
        public bool IsCoin { get; protected set; }
        // Here, I set a boolean (True or False) for specifically picking coin, 
        // that is because the new expected output (from OWL) said that we want to display total value for coins only,
        // So, to prevent displaying total value for other items, I want to set a boolean algrebra here to detect when picking coins.

        protected Collectable(string description)
            // Set String "description"
        {
            Description = description;
            IsCoin = false;
        }

        public string Description { get; }
        // Getter.
        public CollectionBoard Board { get; set; }
        // Here, call the "collectionBoard", and its getter and setter.

        public abstract void Display();
        // Call the void Display() from Displayable.cs.

        public virtual void AddMe(List<Collectable> collection)
        {
            collection.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            // 
            if (displayMessage)
            {
                Display();
            }

            if (this is Treasure treasure)
            {
                treasure.UpdateTotalScore();
                if (IsCoin)
                {
                    treasure.UpdateTotalValue();
                    // use if statement to ensure total value display for coins only.
                }
            }
        }

        public static void PrintDisplayMessage()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("==== All the Collected items ===========");
            Console.WriteLine("========================================");
            displayMessage = true;
            // When detecting the lines above from the main class, I want the display message to be output later than these lines.
        }
    }
}
