using System;

public interface ITransporte
{
    void Mover();
    void Volar(int altitud);
    void GuardarEnBD();
}
