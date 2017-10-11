/// <summary>
/// Papera che è in grado di volare, nuotare e fare quack
/// </summary>
public class MallardDuck : Duck, IFlyable, IQuackable, ISwimable
{
    private double totFly, totSwim;
    public override string Name => "Mallard duck";

    public double TotalFly => totFly;

    public double TotalSwim => totSwim;

    public void Fly(double meters)
    {
        totFly += meters;
    }

    public string Quack()
    {
        return "Quack";
    }

    public void Swim(double meters)
    {
        totSwim += meters;
    }
}

/// <summary>
/// Papera che è in grado di volare, nuotare e fare quack
/// </summary>
public class ReadHeadDuck : Duck, IFlyable, IQuackable, ISwimable
{
    private double totFly, totSwim;
    public override string Name => "Red head duck";

    public double TotalFly => totFly;

    public double TotalSwim => totSwim;

    public void Fly(double meters)
    {
        totFly += meters;
    }

    public string Quack()
    {
        return "Quack";
    }

    public void Swim(double meters)
    {
        totSwim += meters;
    }
}
/// <summary>
/// Papera che è in grado di nuotare e fare quack
/// </summary>
public class RubberDuck : Duck, IQuackable, ISwimable
{
    private double totSwim;
    public override string Name => "Rubber duck";

    public double TotalSwim => totSwim;

    public string Quack()
    {
        return "Squack";
    }

    public void Swim(double meters){
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