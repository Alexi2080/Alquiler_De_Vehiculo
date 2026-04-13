public abstract class Vehiculo
{
    private string? _marca;
    private int _idvehiculo;
    private string? placa;
    private string? _estado;

    public string? Marca 
    { 
        get { return _marca; }
        set 
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _marca = value;
            }
        }
    }

    public int IdVehiculo 
    { 
        get { return _idvehiculo; }
        set 
        {
            if (value > 0)
            {
                _idvehiculo = value;
            }
        }
    }

    public string? Placa 
    { 
        get { return placa; }
        set 
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                placa = value;
            }
        }
    }

    public string? Estado 
    { 
        get { return _estado; }
        set 
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _estado = value;
            }
        }
    }

    public abstract int PrecioAlquiler();
    public abstract double CostoKilometraje();

}
