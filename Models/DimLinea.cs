using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimLinea
{
    public int LineaKey { get; set; }

    public int? LineaPkey { get; set; }

    public string? LineaCod { get; set; }

    public string? LineaPcod { get; set; }

    public string? LineaDescripcion { get; set; }

    public bool? LineaAct { get; set; }

    public string? LineaTipo { get; set; }

    public string? LineaSubTipo { get; set; }
}
