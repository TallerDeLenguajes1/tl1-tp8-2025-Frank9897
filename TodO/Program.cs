using esTarea;


int numTareas = 3;
Tarea[] tareas = new Tarea[numTareas];
//Inicializo variables para el objeto tarea
for (int i = 0; i < tareas.Length; i++)
{
    int tareasID = i + 1;
    Console.WriteLine($"Ingrese el nombre de tarea {i + 1}");
    string? descripcion = Console.ReadLine();
    Console.WriteLine($"Ingrese la duracion de la tarea {i + 1}");
    int duracion = int.Parse(Console.ReadLine());
    tareas[i] = new Tarea(tareasID, descripcion, duracion);
}
//Creo las listas
List<Tarea> listaTareasPendientes = new();
List<Tarea> listaTareasRealizadas = new();

for (int i = 0; i < tareas.Length; i++)
{
    listaTareasPendientes.Add(tareas[i]);
}