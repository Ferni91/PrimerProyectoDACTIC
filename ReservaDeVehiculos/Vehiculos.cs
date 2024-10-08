using System;

public class Vehiculo
{
    public string Modelo { get; set; }
    public decimal PrecioPorDia { get; set; }

    public Vehiculo(string modelo, decimal precioPorDia)
    {
        Modelo = modelo;
        PrecioPorDia = precioPorDia;
    }

    
}

