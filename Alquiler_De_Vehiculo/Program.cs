Vehiculo[] vehiculos = {
    new Camion { Marca = "Ford"},
    new Moto { Marca = "Honda"},
};
Moto moto = new Moto { Marca = "Honda", IdVehiculo = 1, Placa ="M73913", Estado = "Alquilado", Cilindraje = 150 };
Camion camion = new Camion { Marca = "Ford", IdVehiculo = 2, Placa ="G61323", Estado = "Disponible", TipoCarga = "Carga pesada" };

moto.MostrarInformacion();
camion.MostrarInformacion();




for (int i = 0; i < vehiculos.Length; i++)
{
    vehiculos[i].PrecioAlquiler();
    vehiculos[i].CostoKilometraje();
}