class Tripulante
{
    public string Nombre {get;set;}
    public double telefono {get;set;}
    public double Cedula {get;set;}
    public double edad {get;set;}
    public double Tiempo_empresa {get;set;}
    public string sexo {get;set;}
    public string Nombre1 {get;set;}
    public double Sueldo_base {get;set;}
    public double bono {get;set;}
    public double bono_pes {get;set;}
    public double bono_ma {get;set;}

    public Tripulante ( string Nombre1, string Nombre, double telefono , double Cedula, double  edad , double Tiempo_empresa, string sexo, double Sueldo_base,double bono , double bono_pes, double bono_ma)
    {
        this.Nombre1 = Nombre1;
        this.Nombre = Nombre;
        this.telefono = telefono;
        this.Cedula = Cedula;
        this.edad = edad ;
        this.Tiempo_empresa = Tiempo_empresa;
        this.sexo = sexo;
        this.Sueldo_base = Sueldo_base;
        this.bono = bono ;
        this.bono_pes= bono_pes;
        this.bono_ma = bono_ma;
       
    }
    public void imprimir ()
    {
        Console.WriteLine("...................");
        Console.WriteLine ("Datos :"+Nombre1);
        Console.WriteLine("Cedula : "+Cedula);
        Console.WriteLine("Nombre : "+Nombre);
        Console.WriteLine("Sexo : "+sexo);
        Console.WriteLine("Edad : "+edad);
        Console.WriteLine("Telefono : "+telefono);
        Console.WriteLine("Tiempo en la empresa : "  +Tiempo_empresa);
        Console.WriteLine("Sueldo base : "+Sueldo_base);
        Console.WriteLine("Bono : "+bono);
        Console.WriteLine("bono por pescadro : "+bono_pes);
        Console.WriteLine("Bono por marisco : "+bono_ma);
        Console.WriteLine("");
    }
     
}