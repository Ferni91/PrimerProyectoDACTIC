class Program
{
    static void Main(string[] args)
    {
        Vehiculo vehiculo = new Vehiculo("Dodge Charger 1970", 600.00m);

        
        decimal porcentajeDescuento = 10m;
        int diasReserva = 5;

        Console.WriteLine(vehiculo.MostrarInformacion());

        decimal costoTotal = CalcularReserva.CalcularCostoTotal(vehiculo, diasReserva, porcentajeDescuento);

        Console.WriteLine($"El costo total por {diasReserva} días es: {costoTotal:C}");
    }
}
