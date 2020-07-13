using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CrazyMath
{
    class GCD : AbsCrazyMath

    {
        public GCD()
        {
            base._type = "GCD";
        }

        public override void Compute()
        {
            OutputVal = InputVal * 5;
        }
    }
}
