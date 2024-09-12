class Estudiante
{
    public string Nombre { get; set }
    public int Edad { get; set}
}
List<Estudiante> estudiantes = new List<Estudiante>
{
    new Estudiante { Nombre ="ana",Edad = 12},
    new Estudiante { Nombre ="juan",Edad = 10},
    new Estudiante { Nombre ="sofia",Edad = 11}
};

foreach (Estudiante estudiante in estudiantes)
{
    Console.WriteLine("Nombre" + estudiante.Nombre + ",edad: " + estudiante, Edad);
}