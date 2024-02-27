using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class Proyectos
{
    public string? Cif { get; set; }

    public string CodProyecto { get; set; } = null!;

    public string? DescCorta { get; set; }

    public string? DescLarga { get; set; }

    public string? Ush { get; set; }

    public string? Estado { get; set; }

    public string? FechaImportacion { get; set; }

    public bool? Act { get; set; }

    public string? TipoProyecto { get; set; }
}
