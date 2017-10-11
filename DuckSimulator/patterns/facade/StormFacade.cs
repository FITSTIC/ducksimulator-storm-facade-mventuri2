
using System.Collections.Generic;

/// <summary>
/// Interfaccia del sistema Stormo.
/// Uno stormo viene riempito di papere e poi viene fatto migrare verso una direzione.
/// </summary>
public interface Storm<Tduck> where Tduck : Duck, new()
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
    /// Fa migrare lo stormo verso una direzione
    /// </summary>
    /// <param name="dir">Direzione verso la quale tutto lo stormo sta migrando</param>
    /// <param name="distance">Distanza che deve percorrere lo stormo</param>
    void Migrate(Direction dir, double distance);
}