using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimFecha
{
    public int? PeriodoKey { get; set; }

    public string? Dia { get; set; }

    public string? Mes { get; set; }

    public string? Año { get; set; }

    public string? Descripcion { get; set; }
}
