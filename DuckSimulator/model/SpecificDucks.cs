public class MallardDuck : Duck, IFlayable, IQuackable, ISwimable
{
    private int totFlyKM, totSwimKM;
    public override string Name => "Mallard duck";

    public int TotalFlyKM => totFlyKM;

    public int TotalSwimKM => totSwimKM;

    public void Fly(int meters)
    {
        totFlyKM += meters;
    }

    public string Quack()
    {
        return "Quack";
    }

    public void Swim(int meters)
    {
        totSwimKM += meters;
    }
}

public class ReadHeadDuck : Duck, IFlayable, IQuackable, ISwimable
{
    private int totFlyKM, totSwimKM;
    public override string Name => "Red head duck";

    public int TotalFlyKM => totFlyKM;

    public int TotalSwimKM => totSwimKM;

    public void Fly(int meters)
    {
        totFlyKM += meters;
    }

    public string Quack()
    {
        return "Quack";
    }

    public void Swim(int meters)
    {
        totSwimKM += meters;
    }
}

public class RubberDuck : Duck, IQuackable, ISwimable
{
    private int totSwimKM;
    public override string Name => "Rubber duck";

    public int TotalSwimKM => totSwimKM;

    public string Quack()
    {
        return "Squack";
    }

    public void Swim(int meters){
        totSwimKM += 1;
    }
}

public class DecoyDuck : Duck
{
    public override string Name => "Decoy duck";
}