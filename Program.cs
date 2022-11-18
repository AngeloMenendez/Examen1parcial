internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Barco n1 = new Barco ("Tercero A",10,30000);
        n1.imprimir();
        Gps n2= new Gps(82454,92321,18/11/2022,30,09);
        n2.imprimir();
        Tripulante n3 = new Tripulante(" Capitan","Marco",098432123,2339876542,20,20,"M",4500,900,0,0);
        n3.imprimir();
        Capitan n4 = new Capitan(" Capitan","Marco",098432123,2339876542,20,20,"M",4500,900,0,0);
        n4.imprimir();
        Jefe_flota n5 = new Jefe_flota("jefe de flota", "juan",0984321123,2339876542,23,15,"M",3500,0,50,180);
        n5.imprimir();
        Marinero n6 = new Marinero(" Marinero","Pedro",098432123,2339876542,10,10,"M",900,1750,0,0);
        n6.imprimir();
        Marinero2 n7 = new Marinero2("Marinero","Maria",098432123,2339876542,19,10,"F",900,1750,0,0);
        n7.imprimir();
        Marinero3 n8 = new Marinero3("Marinero","Pedro",098432123,2339876542,21,10,"M",900,1750,0,0);
        n8.imprimir();

        List<Tripulante> listafigura=new List<Tripulante>();
            listafigura.Add(n3);
            listafigura.Add(n4);
            listafigura.Add(n5);
            listafigura.Add(n6);
            listafigura.Add(n7);
            listafigura.Add(n8);
            

            foreach(ICalcular_bono item in listafigura)
            {
                Console.WriteLine("-------");
                item.Calcular_bono();
            }


    }
}