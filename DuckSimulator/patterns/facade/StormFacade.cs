using System.Collections.Generic;

/// <summary>
/// Interfaccia del sistema Stormo.
/// Uno stormo viene riempito di papere e poi viene fatto migrare verso una direzione.
/// </summary>
public interface IStorm<Tduck> where Tduck : Duck, new()
{
    /// <summary>
    /// Lista delle papere che compongono lo stormo
    /// </summary>
    /// <returns></returns>
    List<Tduck> Ducks { get; }
    /// <summary>
    /// Riempie lo stormo
    /// </summary>
    /// <param name="nDucks">numero di papere che compongono lo stormo</param>
    void FillStorm(int nDucks);
    /// <summary>
    /// Posizione corrente sulle cordinate X dello stormo
    /// </summary>
    /// <returns></returns>
    double PositionX { get; }
    /// <summary>
    /// Posizione corrente sulle cordinate Y dello stormo
    /// </summary>
    /// <returns></returns>
    double PositionY { get; }
    /// <summary>
    /// Contatore totale dello spazio percorso dallo stormo durante la migrazione.
    /// </summary>
    /// <returns></returns>
    double TotalDistance { get; }
    /// <summary>
    /// Fa migrare lo stormo verso una direzione
    /// </summary>
    /// <param name="dir">Direzione verso la quale tutto lo stormo sta migrando</param>
    /// <param name="distance">Distanza che deve percorrere lo stormo</param>
    void Migrate(Direction dir, double distance);
    /// <summary>
    /// Distanza in linea d'aria dal punto di partenza.
    /// </summary>
    /// <returns></returns>
    double LineDistanceFromStart { get; }
}

public class Storm<Tduck> : IStorm<Tduck> where Tduck : Duck, new()
{
    public Storm()
    {

    }
    public List<Tduck> Ducks => throw new System.NotImplementedException();

    public double PositionX => throw new System.NotImplementedException();

    public double PositionY => throw new System.NotImplementedException();

    public double LineDistanceFromStart => throw new System.NotImplementedException();

    public double TotalDistance => throw new System.NotImplementedException();

    public void FillStorm(int nDucks)
    {
        throw new System.NotImplementedException();
    }

    public void Migrate(Direction dir, double distance)
    {
        throw new System.NotImplementedException();
    }
}