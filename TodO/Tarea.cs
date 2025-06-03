namespace esTarea;

class Tarea
{
    private int tareaID;
    private string? descripcion;
    private int duracion;

    public Tarea(int tareaID, string? descripcion, int duracion)
    {
        this.tareaID = tareaID;
        this.descripcion = descripcion;
        this.duracion = duracion;
    }

    public int TareaID { get => tareaID; set => tareaID = value; }
    public string? Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion;
        set
        {
            if (value > 10 || value < 100)
            {
                duracion = value;
            }
            ;
        }
    }
}