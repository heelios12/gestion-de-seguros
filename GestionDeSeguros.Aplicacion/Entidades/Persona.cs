namespace GestionDeSeguros.Aplicacion.Entidades;

public abstract class Persona
{
    public string Nombre {get;set;}
    public string Apellido {get;set;}
    public string Dni {get;set;}
    public string Telefono{get;set;} = "";

    public Persona(string nombre, string apellido, string dni)
    {
        Nombre   = nombre;
        Apellido = apellido;
        Dni      = dni;
    }


    public override string ToString()
    {
        return $"Nombre: {Nombre}, Apellido: {Apellido}, Dni: {Dni}, Telefono: {Telefono}";
    }
}