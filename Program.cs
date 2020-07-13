using System;

namespace CrazyMath

{
    class Program
    {
       

        static void Main(string[] args)
        {
            GCD _gcd = new GCD();
            LCM _lcm = new LCM(7);
            _lcm.Compute();
            _gcd.Compute(7);
            _gcd.Display();
            _lcm.Display();
           // AbsCrazyMath a = new GCD();
           // a.Display();
           // ICrazyMath ia = new LCM();
           // ia.Display();
           // GCD d = a;
           //a=_lcm;
            Console.ReadLine();
            




        }
    }
    
}
