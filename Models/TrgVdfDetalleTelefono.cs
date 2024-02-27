using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfDetalleTelefono
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public string? TelefExt { get; set; }

    public string? FechaHora { get; set; }

    public string? DuracSes { get; set; }

    public string? Tipo { get; set; }

    public decimal? Volumen { get; set; }

    public string? Destino { get; set; }

    public string? NoRecep { get; set; }

    public string? NoOrigen { get; set; }

    public string? Tarifa { get; set; }

    public decimal? Importe { get; set; }

    public string? ExtOrigen { get; set; }

    public string? Canal { get; set; }

    public string? TipoFact { get; set; }

    public string? Pasos { get; set; }

    public decimal? Duracion { get; set; }

    public decimal? ImporteNeto { get; set; }

    public int? ExcedeLimiteDuracion { get; set; }

    public string? Descripcion { get; set; }

    public short? Packsg { get; set; }

    public string? TelefExtOld { get; set; }
}
