namespace GestionDeSeguros.Aplicacion.Entidades;

public class Poliza
{
    public int Id {get; set;}
    public int ValorAsegurado {get; set;}
    public string Franquicia {get; set;} = "";
    public TipoCobertura Cobertura{get; set;}
    public DateTime FechaInicioVigencia {get; set;}
    public DateTime FechaFinVigencia {get; set;}

    public int VehiculoId {get; set;}

    public Poliza(int valorAsegurado, TipoCobertura cobertura, DateTime fechaInicioVigencia, DateTime fechaFinVigencia)
    {
        ValorAsegurado      = valorAsegurado;
        Cobertura           = cobertura;
        FechaInicioVigencia = fechaInicioVigencia;
        FechaFinVigencia    = fechaFinVigencia;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Valor Asegurado: {ValorAsegurado}, Franquicia: {Franquicia}, Cobertura: {(int)Cobertura}, Fecha de Inicio Vigencia: {FechaInicioVigencia}, Fecha de Fin Vigencia: {FechaFinVigencia}, Id del Vehiculo Asegurado: {VehiculoId}";
    }
}
