﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class MagicWand : Tool
    {
        public MagicWand(string description) : base(description)
        {
            // Constructor...
            // Since we do not need to collect score and value, so nothing set here...
        }

        public override void Display()
        {
            // Override this specific line for display in the end.
            Console.WriteLine($"MagicWand {Description} is displayed");
        }

        public override void DoAction()
        {
            // Specialize the line to be output for DoAction for magic wand.
            Console.WriteLine("MagicWand is Used");
        }
    }
}