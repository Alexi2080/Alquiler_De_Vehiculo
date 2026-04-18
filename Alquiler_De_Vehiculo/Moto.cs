public class Moto : Vehiculo
{
    private int _cilindraje;
    public int Cilindraje
    {
        get { return _cilindraje; }
        set
        {
            if (value > 0)
            {
                _cilindraje = value;
            }
        }
    }

    public override int PrecioAlquiler()
    {
        Console.WriteLine();
        Console.WriteLine("Precio para la moto");
        Console.WriteLine("El precio de alquiler de la moto es de $50 por día");
        return 50;
    }

    public override double CostoKilometraje()
    {     
        Console.WriteLine("El costo por kilómetro de la moto es de $5.50");
        return 5.50;
      
    }
    public void MostrarInformacion()
    {
        Console.WriteLine("Información de la moto:");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"ID: {IdVehiculo}");
        Console.WriteLine($"Placa: {Placa}");
        Console.WriteLine($"Estado: {Estado}");
        Console.WriteLine($"Cilindraje: {Cilindraje} cc");
        Console.WriteLine();
    }

}