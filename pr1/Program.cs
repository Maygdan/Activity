using System.Data.SqlTypes;

namespace Practice3
{
    public class A
    {
        protected string _name;
        protected int _value;

        public string Name=> _name;
        private int Value=> _value;
        public A(string name, int value)
        {
            _name=name;
            _value=value;
        }
        public void Method1()
        {
            Console.WriteLine("Method class A");
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name: {_name} \nValue: {_value}");
        }
        public void Method2()
        {
            Console.WriteLine("Also a method class A");
        }
    
    }
    public class B : A
    {
        private string _word;
        private bool _isValid;
        public string World=> _word;
        
        public B(string name, int value,string word):base(name,value)
        {
            _word=word;
            _isValid=true;
        }
        public B(string name, int value,string word,bool isValid):this(name,value,word)
        {
            _word=word;
            _isValid=isValid;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Hello");
        }
        
    }
    
}
