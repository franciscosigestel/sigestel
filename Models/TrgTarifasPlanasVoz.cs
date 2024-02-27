using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgTarifasPlanasVoz
{
    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? CuotaMensual { get; set; }

    public string? Franquicia { get; set; }

    public string? EstLlamada { get; set; }

    public string? PrecioMinuto { get; set; }
}
