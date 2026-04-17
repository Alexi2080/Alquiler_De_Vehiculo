public class Camion : Vehiculo 
{
    private string? _tipocarga;

    public string? TipoCarga
    {
        get { return _tipocarga; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _tipocarga = value;
            }
        }
    }
    public override int PrecioAlquiler()
    {
       Console.WriteLine("El precio de alquiler del camión es de $150 por día");
       return 150;
    }

    public override double CostoKilometraje()
    {
        Console.WriteLine("El costo por kilómetro del camión es de $9.75");
        return 9.75;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"ID: {IdVehiculo}");
        Console.WriteLine($"Placa: {Placa}");
        Console.WriteLine($"Estado: {Estado}");
        Console.WriteLine($"Tipo de carga: {TipoCarga}");
    }

}
