namespace GestionDeSeguros.Aplicacion.Entidades;

public class Tercero : Persona
{
    public int Id {get; set;}
    public string Aseguradora {get; set;} = "";
    
    public int SiniestroId {get; set;}
    
    public Tercero(string nombre, string apellido, string dni) : base(nombre, apellido, dni)
    {

    }
}
