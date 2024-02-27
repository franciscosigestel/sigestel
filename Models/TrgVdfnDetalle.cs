using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfnDetalle
{
    public string? Ciclo { get; set; }

    public string FactNo { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? FechaHora { get; set; }

    public string? NLlamado { get; set; }

    public string? Tipo { get; set; }

    public string? Destino { get; set; }

    public string? Servicio { get; set; }

    public string? Duracion { get; set; }

    public string? Cantidad { get; set; }

    public string? LlamadaNo { get; set; }

    public string? Extension { get; set; }

    public string? Tarifa { get; set; }

    public string? ImporteNeto { get; set; }

    public string? Receptor { get; set; }

    public string? Descripcion { get; set; }

    public string? Volumen { get; set; }

    public string? Importe { get; set; }

    public string? Canal { get; set; }

    public string? DuracSesion { get; set; }

    public string? Pasos { get; set; }

    public string? TipoFact { get; set; }
}
