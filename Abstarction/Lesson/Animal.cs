﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Animal
    {
        public string Name;
        public byte Age;

        public abstract void MakeSound();

        public virtual void ShowInfo()
        {
            Console.WriteLine(Name + " - " + Age);
        }
    }
}
