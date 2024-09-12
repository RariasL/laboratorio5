List<int> calificaciones = new list<int> { 85, 90, 78, 92, 88 };

int suma = 0;

foreach(int calificacion in calificaciones)
{
    suma += calificacion;
}
double promedio = suma / (double)calificaciones.Count;

Console.WriteLine($"el promedio de las calificaciones es:{promedio}");