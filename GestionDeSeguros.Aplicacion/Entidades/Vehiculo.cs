namespace GestionDeSeguros.Aplicacion.Entidades;

public class Vehiculo
{
    public int Id {get; set;}
    public string Dominio {get; set;}
    public string Marca {get; set;}
    public int AnioDeFabricacion {get; set;}

    public int TitularId {get; set;}


    public Vehiculo(string dominio, string marca, int anioDeFabricacion)
    {
        Dominio           = dominio;
        Marca             = marca;
        AnioDeFabricacion = anioDeFabricacion;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Dominio: {Dominio}, Marca: {Marca}, Año de Fabricacion: {AnioDeFabricacion}, Id del Titular: {TitularId}";
    }

}
