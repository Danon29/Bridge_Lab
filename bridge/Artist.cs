﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    class Artist
    {
        public void DoSmth(Abstraction abstraction)
        {
            Console.WriteLine(abstraction.Draw());
        }
    }
}
