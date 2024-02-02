using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        protected Tool(string description) : base(description)
        {
            // Constructor...
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            // Here, just set AddMe in List<Collectable> for Collectable.cs.
            DoAction();
            // Call a DoAction method here.
        }

        public abstract void DoAction();
        // Since this is abstract void, nothing initially set, I will specialize for different tools (axe and magic wand) in their classes.
    }
}