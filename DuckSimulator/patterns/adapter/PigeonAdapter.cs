/// <summary>
/// Adattatore che permette di utilizzare un piccione come una papera
/// </summary>
public class PigeonAdapter : Duck, IFlyable, IQuackable, ISwimable
{
    /// <summary>
    /// Contatori totali del nuoto e del volo
    /// </summary>
    private int totFly, totSwim;
    /// <summary>
    /// Modello del piccione da adattare
    /// </summary>
    private readonly Pigeon pigeon;
    /// <summary>
    /// Costruttore dell'adattatore che accetta in input il piccione da adattare
    /// </summary>
    /// <param name="p">Piccione da adattare a papera</param>
    public PigeonAdapter(Pigeon p)
    {
        this.pigeon=p;
    }
    /// <summary>
    /// Nome del piccione usato come papera
    /// </summary>
    public override string Name => "Pigeon duck";
    /// <summary>
    /// Contatore totale del volo
    /// </summary>
    public int TotalFly => totFly;
    /// <summary>
    /// Contatore totale del nuoto
    /// </summary>
    public int TotalSwim => totSwim;
    /// <summary>
    /// Azione di volo: invoca l'azione del volo sul piccione ed aggiorna i contatori totali
    /// </summary>
    /// <param name="meters">Metri da volare</param>
    public void Fly(int meters)
    {
        this.pigeon.FlyAway(meters);
        totFly += meters;
    }

    public string Quack()
    {
        return "Quack";
    }
    /// <summary>
    /// Azione di nuoto: invoca l'azione di camminare sul piccione ed aggiorna i contatori totali.
    /// I metri da nuotare vengono raddoppiati perché il meccanismo di camminata è meno potente rispetto al meccanismo di nuoto.
    /// </summary>
    /// <param name="meters">Metri da nuotare</param>
    public void Swim(int meters)
    {
        this.pigeon.Walk(meters*2);
        totSwim += meters;
    }
}