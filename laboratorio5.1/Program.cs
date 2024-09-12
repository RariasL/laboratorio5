private int[] sueldos;

public void Cargar()
{
    sueldos = new int[6];
    for(int f = 1; f<=5; f++)
    {
        Console.Write("ingrese sueldo del operario " + f + ":");
        String linea;
        linea = Console.ReadLine();
        sueldos[f] = int.Parse(linea);
    }
}
public void imprimir()
{
    Console.WriteLine("los 5 sueldos de los operarios \n");
    for(int f = 1; f <= 5; f++)
    {
        Console.WriteLine("[" + sueldos[f] + "]");
    }
    Console.ReadKey();
}
static void Main(string[] args)
{
    PruebaVector1 pv = new PruebaVector1();
    pv.Cargar();
    pv.imprimir();
}