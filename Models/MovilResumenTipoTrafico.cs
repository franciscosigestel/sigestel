using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class MovilResumenTipoTrafico
{
    public string Ntelefono { get; set; } = null!;

    public string Nextension { get; set; } = null!;

    public DateTime? FechaFactura { get; set; }

    public string TipoTrafico { get; set; } = null!;

    public int? NumLlamadas { get; set; }

    public string UnidadMedida { get; set; } = null!;

    public double? CantMedida { get; set; }

    public double? Importe { get; set; }

    public string? StrDescGrupoTrafico { get; set; }

    public string Nfactura { get; set; } = null!;
}
