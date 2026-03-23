namespace CW5.Variant00
{
    public class Task2
    {
        public class Number : INumber
        {
            protected double _num;
            public double Num=>_num;
            public double Real=>Num;
            public virtual double Abs=>Math.Abs(Num);
            public  int Sign=>Math.Sign(Num);
            public virtual void Sum(INumber a)=>_num+=a.Real;
            public virtual void Sub(INumber a)=>_num-=a.Real;
            public virtual void Mul(INumber a)=>_num*=a.Real;
            public virtual void Neg()=>_num*=-1;
            public Number(double num)=>_num=num;
            public virtual void Div(INumber a)
            {
                if(a.Real==.0)return;
                _num/=a.Real;
            }

        public class ComplexNumber : Number, IComplexNumber
        {
            private double _maginary;
            

            public double Maginary=> _maginary;
            public int S=> _s;
            public ComplexNumber(double num, double maginary=0) : base(num)
                {
                    maginary=_maginary;
                }

            public double Imaginary=>Maginary;
            public int ISign =>Math.Sign(Maginary);
                
                
            public override double Abs=>Math.Abs(Num);
            public override void Sum(INumber a)=>_num+=a.Real;
            public override void Sub(INumber a)=>_num-=a.Real;
            public override void Mul(INumber a)=>_num*=a.Real;
            public override void Neg()=>_num*=-1;
            public override void Div(INumber a)
            {
                if(a.Real==.0)return;
                _num/=a.Real;
            }
            }
        }
    }
}