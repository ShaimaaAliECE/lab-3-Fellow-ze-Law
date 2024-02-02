using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        protected Treasure(string description) : base(description)
        {
            // Constructor...
        }

        public virtual void UpdateTotalValue()
        {
            Board?.UpdateTotalValue(0); 
            // I set this because the total value will be overriden in other class, here is more like a skeleton.
        }

        public abstract void UpdateTotalScore();
    }
}
