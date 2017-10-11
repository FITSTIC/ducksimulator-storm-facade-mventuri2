/// <summary>
/// Classe di un piccione
/// </summary>
public sealed class Pigeon
{
    /// <summary>
    /// Contatori totali dei metri impiegati nelle azioni di camminare e volare
    /// </summary>
    private double totMetersWalk, totFlyAway;
    /// <summary>
    /// Azione cammina
    /// </summary>
    /// <param name="meters">Metri da camminare</param>
    public void Walk(double meters)
    {
        totMetersWalk += meters;
    }
    /// <summary>
    /// Azione di emettere il verso gru gru
    /// </summary>
    /// <returns>Verso emesso</returns>
    public string Gru()
    {
        return "Gru gru";
    }

    /// <summary>
    /// Azione di volare
    /// </summary>
    /// <param name="meters">Metri da volare</param>
    public void FlyAway(double meters)
    {
        totFlyAway += meters;
    }
}