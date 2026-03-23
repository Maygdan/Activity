namespace CW5.Variant00
{
    public class Task1{
        public struct Number : INumber
        {
            private double _num;
            public double Num=>_num;
            public double Real=>Num;
            public double Abs=>Math.Abs(Num);
            public int Sign=>Math.Sign(Num);
            public void Sum(INumber a)=>_num+=a.Real;
            public void Sub(INumber a)=>_num-=a.Real;
            public void Mul(INumber a)=>_num*=a.Real;
            public void Neg()=>_num*=-1;
            public Number(double num)=>_num=num;
            public void Div(INumber a)
            {
                if(a.Real==.0)return;
                _num/=a.Real;
            }
        }
    }
}