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