class Jefe_flota:Tripulante,ICalcular_bono
{
      public Jefe_flota ( string Nombre1, string Nombre, double telefono , double Cedula, double  edad , double Tiempo_empresa, string sexo, double Sueldo_base,double bono , double bono_pes, double bono_ma ):base(Nombre1, Nombre, telefono, Cedula, edad, Tiempo_empresa, sexo, Sueldo_base, bono, bono_pes, bono_ma)
    {
 
    }
    public void Calcular_bono()
    {
        double sueldo_total;

        sueldo_total = (Sueldo_base + bono_pes+ bono_ma);
        Console.WriteLine("Sueldo total :"+sueldo_total);
    }

}