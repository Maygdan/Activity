using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;

namespace pr2;
public abstract class Animal
{
   private int _id;
   public abstract string Type{get;}

   public Animal(int id)
    {
        _id=id;
    }    

    public abstract void Voice();

    public virtual void Print()
    {
        Console.WriteLine("Animal ID"+_id);
    }
}
public class Cat : Animal
{
    public Cat(int id):base(id){}

    public override string Type => "Кошка";

    public override void Voice()
    {
        Console.WriteLine("Meow");
    }

}