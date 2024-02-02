using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public interface Displayable
    {
        void Display();
        // Call the display method from this interface, this will be use for other classes in this lab.
        // Thus, to personalize "unique" features for other classes about void "Display()", I will do it in other classes.
    }
}
