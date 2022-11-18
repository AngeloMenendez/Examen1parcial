class Gps
{
    public double CordenadaX { get; set;}
    public double CordenadaY{ get;set;}
    public double fecha {get;set;}
    public double Dia_Tripulantes{ get;set;}
    public double Hora_registro {get;set;}

    public Gps (double CordenadaX, double CordenadaY, double fecha, double Dia_Tripulantes, double Hora_registro)
    {
        this.CordenadaX = CordenadaX;
        this.CordenadaY = CordenadaY;
        this.fecha = fecha;
        this.Dia_Tripulantes= Dia_Tripulantes;
        this.Hora_registro = Hora_registro;
    }
    public void imprimir ()
    {
        Console.WriteLine("...................");
        Console.WriteLine ("----------Datos de ubicacion------------");
        Console.WriteLine("Cordenada X : "+CordenadaX);
        Console.WriteLine("Cordenada y: "+CordenadaY);
        Console.WriteLine("Dias tripulados : "+Dia_Tripulantes);
        Console.WriteLine("Fecha de registro : "+fecha);
        Console.WriteLine ("Hora de registro : "+Hora_registro);
    }
    
}