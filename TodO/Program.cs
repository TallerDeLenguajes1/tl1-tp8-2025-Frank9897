using esTarea;



//Creo las listas
List<Tarea> listaTareasPendientes = new();
List<Tarea> listaTareasRealizadas = new();
bool continuar = true;
do
{
    Console.WriteLine("-----------MENU-----------\n1.Crear Tarea Pendiete\n2.Mover tareas pendiente a realizadas por ID\n3.Buscar tareas realizadas por palabra clave\n4.Mostrar listas\nIngrese opcion a elegir (0 para terimnar)");
    int eleccion = int.Parse(Console.ReadLine());
    switch (eleccion)
    {
        case 1:
            creartarea(listaTareasPendientes);
            break;
        case 2:
            movertareaXid(listaTareasPendientes,listaTareasRealizadas);
            break;
        case 3:
            buscarpordescripcion(listaTareasPendientes);
            break;
        case 4:
            mostrarPendientes(listaTareasPendientes);
            mostrarRealizadas(listaTareasRealizadas);   
            break;
        case 0:
            continuar = false;
            break;    
        default:
            Console.WriteLine("Opcion invalida...");
            continue;
    }
} while (continuar);



static void buscarpordescripcion(List<Tarea> listaTareasPendientes)
{
    Console.WriteLine("Ingresar una palabra clave para buscar la descripcion en tareas pendientes");
    string? pclave = Console.ReadLine();
    bool encontrada = false;
    foreach (Tarea tarea in listaTareasPendientes)
    {
        if (tarea.Descripcion.Contains(pclave, StringComparison.OrdinalIgnoreCase))
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

static void creartarea(List<Tarea> listaTareasPendientes )
{
    Random rand = new Random();
    int control = listaTareasPendientes.Count;
    int tareasID = listaTareasPendientes.Count + 1;
    Console.WriteLine("Ingrese La descripcion de tarea");
    string? descripcion = Console.ReadLine();
    int duracion = rand.Next(10, 100);
    listaTareasPendientes.Add(new Tarea(tareasID, descripcion, duracion));
    if (listaTareasPendientes.Count > control)
    {
        Console.WriteLine("Se aniadio la tarea correctamente.");
    }else
    {
        Console.WriteLine("No se pudo cargar la tarea");
    }
}

static void mostrarPendientes(List<Tarea> listaTareasPendientes)
{
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
}

static void mostrarRealizadas(List<Tarea> listaTareasRealizadas)
{
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
}

static void movertareaXid(List<Tarea> listaTareasPendientes,List<Tarea> listaTareasRealizadas)
{
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
}