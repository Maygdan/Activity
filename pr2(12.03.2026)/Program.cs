namespace pr2;
public abstract class Animal
{
    protected int _id;
    private int _Count=0;


    public abstract string Type { get; }
    public abstract double Height {get;}
    public abstract double Weight {get;}
    public abstract string Name {get;}
    public Animal()
    { 
        _id =_Count;
        _Count++;
    }
    public abstract void Voice();
    public virtual void About()
    {
        Console.WriteLine($"ID: {_id}"); 
    }

    public virtual void Print()
    {
        Console.WriteLine("It's a cat, not a dog");
    }
}

public class Cat : Animal
{
    protected double _height;
    protected double _weight;

    protected string _name;

    public Cat(double height, double weight,string name)
    {
        _name=name;
        _height = height;
        _weight = weight;
    }

    public override string Type => "Кошка";
    public override double Height => _height;
    public override double Weight => _weight;
    public override string Name => _name;

    public override void About()
    {
        base.About();Console.WriteLine($"Name: {_name} \nWeight: {_weight} \nHeight: {_height} ");
    }

    public override void Voice()
    {
        Console.WriteLine("Meow");
    }
}
