class Barco
{
 public string Nombre { get;set;}
    public double Capacidad_pasajero{get;set;}
    public double Capacidad_carga { get;set;}

    public Barco (string Nombre, double Capacidad_pasajero, double Capacidad_carga)
    {
        this.Nombre = Nombre;
        this.Capacidad_pasajero = Capacidad_pasajero ;
        this.Capacidad_carga = Capacidad_carga;

    }

    public void imprimir ()
    {
        Console.WriteLine("...................");
        Console.WriteLine ("----------Datos de barco------------");
        Console.WriteLine("Nombre : "+Nombre);
        Console.WriteLine("Tipo : Pesquero");
        Console.WriteLine("Capacidad de pasajeros :"+Capacidad_pasajero);
        Console.WriteLine ("Capacidad almacen :"+Capacidad_carga);
    }
}

    
