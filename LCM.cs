using System;
using System.Collections.Generic;
using System.Text;

namespace CrazyMath
{
    class LCM:AbsCrazyMath
    {
        private const string _typecons= "LCM";
        public LCM()
        {
            base._type =_typecons;
        }

        public LCM(int x)
        {
            InputVal = x;
            base._type =_typecons;


        }
        public override void Compute()
        {
            OutputVal = InputVal * 4;
        }
        
    }
}
