public abstract class Duck
{
    public abstract string Name {get;}
    public string Display()
    {
        return $"I am {Name}";
    }
}

public interface IFlayable
{
    int TotalFlyKM { get; }
    void Fly(int meters);
}

public interface ISwimable
{
    int TotalSwimKM { get; }
    void Swim(int meters);
}

public interface IQuackable
{
    string Quack();
}