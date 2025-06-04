using esTarea;


int numTareas = 3;
Tarea[] tareas = new Tarea[numTareas];
//Inicializo variables para el objeto tarea
for (int i = 0; i < tareas.Length; i++)
{
    Random rand = new Random();
    int tareasID = i + 1;
    Console.WriteLine($"Ingrese La descripcion de tarea {i + 1}");
    string? descripcion = Console.ReadLine();
    int duracion = rand.Next(10, 100);
    tareas[i] = new Tarea(tareasID, descripcion, duracion);
}
//Creo las listas
List<Tarea> listaTareasPendientes = new();
List<Tarea> listaTareasRealizadas = new();

for (int i = 0; i < tareas.Length; i++)
{
    listaTareasPendientes.Add(tareas[i]);
}

Console.WriteLine("-----------Tareas Pendientes-----------");
foreach (var tarea in listaTareasPendientes)
{
    Console.WriteLine($"ID tarea: {tarea.TareaID}\nDescripcion: {tarea.Descripcion}\nDuracion {tarea.Duracion} min");
}

Console.WriteLine("Ingrese la ID de tarea que desea mover a tareas realizadas");
int opc = int.Parse(Console.ReadLine());

for (int i = listaTareasPendientes.Count - 1; i >= 0; i--)
{

    if (listaTareasPendientes[i].TareaID == opc)
    {
        listaTareasRealizadas.Add(listaTareasPendientes[i]);
        Console.WriteLine($"Tarea ID: {opc} Movida con exito");
        listaTareasPendientes.RemoveAt(i);
        break;
    }
    
}

Console.WriteLine("Ingresar una palabra clave para buscar la descripcion en tareas pendientes");
string? pclave = Console.ReadLine();

buscarpordescripcion(pclave,listaTareasPendientes);

Console.WriteLine("-----------Tareas Pendientes-----------");
if (listaTareasPendientes.Count == 0)
{
    Console.WriteLine("Ninguna");
}else
{
    foreach (Tarea lista1 in listaTareasPendientes)
    {
        Console.WriteLine($"Tarea ID: {lista1.TareaID}\nDescripcion: {lista1.Descripcion}\nDuracion: {lista1.Duracion} min");
    }
}

Console.WriteLine("-----------Tareas Realizadas-----------");
if (listaTareasRealizadas.Count == 0)
{
    Console.WriteLine("Ninguna");
}else
{
    foreach (Tarea lista2 in listaTareasRealizadas)
    {
        Console.WriteLine($"Tarea ID: {lista2.TareaID}\nDescripcion: {lista2.Descripcion}\nDuracion: {lista2.Duracion} min");
    }
}




static void buscarpordescripcion(string descripcion, List<Tarea> listaTareasPendientes)
{
    bool encontrada = false;
    foreach (Tarea tarea in listaTareasPendientes)
    {
        if (tarea.Descripcion.Contains(descripcion,StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"-----------Tarea encontrada-----------\nTarea ID: {tarea.TareaID}\nDescripcion: {tarea.Descripcion}\nDuracion: {tarea.Duracion} min\n");
            encontrada = true;
        }
    }
    if (!encontrada)
    {
        Console.WriteLine("No se encontro ninguna descripcion.");
    }
}
