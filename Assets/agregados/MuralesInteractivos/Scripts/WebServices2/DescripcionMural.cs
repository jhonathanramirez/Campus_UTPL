
public class DescripcionMural
{
    public string [] autores { get; set; }
    public int año { get; set; }
    public string dimensiones { get; set; }
    public string tecnica { get; set; }
    public string ubicacion { get; set; }

}

public class Root
{
    public DescripcionMural descripcion_mural { get; set; }

}
