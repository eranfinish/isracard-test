using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcService.DAL
{
    public abstract class Operator
    {
        protected float a;
        protected float b;
        public Operator(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public abstract float Calculate();
    }

    public class Plus : Operator
    {

        public Plus(float a, float b) : base(a, b)
        {
        }

        public override float Calculate()
        {
            return a + b;
        }
    }

    public class Minus : Operator
    {

        public Minus(float a, float b) : base(a, b)
        {
        }

        public override float Calculate()
        {
            return a - b;
        }
    }
    public class Devide : Operator
    {

        public Devide(float a, float b) : base(a, b)
        {
        }

        public override float Calculate()
        {
            if(b == 0)
            {
                throw new Exception("Not Comutebale!"); 
            }
             return a / b;
            
        }


    }

    public class Multiply : Operator
    {

        public Multiply(float a, float b) : base(a, b)
        {
        }

        public override float Calculate()
        {
            
            return a * b;

        }


    }
}
