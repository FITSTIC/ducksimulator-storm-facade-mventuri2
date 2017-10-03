/// <summary>
/// Papera che è in grado di volare, nuotare e fare quack
/// </summary>
public class MallardDuck : Duck, IFlayable, IQuackable, ISwimable
{
    private int totFly, totSwim;
    public override string Name => "Mallard duck";

    public int TotalFly => totFly;

    public int TotalSwim => totSwim;

    public void Fly(int meters)
    {
        totFly += meters;
    }

    public string Quack()
    {
        return "Quack";
    }

    public void Swim(int meters)
    {
        totSwim += meters;
    }
}

/// <summary>
/// Papera che è in grado di volare, nuotare e fare quack
/// </summary>
public class ReadHeadDuck : Duck, IFlayable, IQuackable, ISwimable
{
    private int totFly, totSwim;
    public override string Name => "Red head duck";

    public int TotalFly => totFly;

    public int TotalSwim => totSwim;

    public void Fly(int meters)
    {
        totFly += meters;
    }

    public string Quack()
    {
        return "Quack";
    }

    public void Swim(int meters)
    {
        totSwim += meters;
    }
}
/// <summary>
/// Papera che è in grado di nuotare e fare quack
/// </summary>
public class RubberDuck : Duck, IQuackable, ISwimable
{
    private int totSwim;
    public override string Name => "Rubber duck";

    public int TotalSwim => totSwim;

    public string Quack()
    {
        return "Squack";
    }

    public void Swim(int meters){
        totSwim += 1;
    }
}

/// <summary>
/// Papera che non è in grado nè di nuotare nè di volare nè di fare Quack
/// </summary>
public class DecoyDuck : Duck
{
    public override string Name => "Decoy duck";
}