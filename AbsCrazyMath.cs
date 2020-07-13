using System;
using System.Collections.Generic;
using System.Text;

namespace CrazyMath
{
    public abstract class AbsCrazyMath : ICrazyMath
   
    {
        protected string _type;

        #region Properties
        public int InputVal { get; set; }

        public int OutputVal { get; set; }

        #endregion

        public abstract void Compute();
       

        public virtual int Compute(int x)
        {
            InputVal = x;
            Compute();
            return OutputVal;
        }

       public int Compute(float y)
        {
            throw new NotImplementedException();
        }

       public void Display()
        {
            Console.WriteLine(_type);
            Console.WriteLine(OutputVal.ToString());
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
