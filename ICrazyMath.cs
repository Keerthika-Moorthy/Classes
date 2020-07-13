using System;
using System.Collections.Generic;
using System.Text;

namespace CrazyMath
{
   internal interface ICrazyMath:IDisposable
    {
        public int InputVal { get; }
        public int OutputVal { set; }
        public void Compute();
        public int Compute(int x);
        public int Compute(float y);
        void Display();
    }
}
