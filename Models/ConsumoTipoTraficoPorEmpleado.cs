using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ConsumoTipoTraficoPorEmpleado
{
    public string NTelfConex { get; set; } = null!;

    public string? Tipo { get; set; }

    public string? MarcAbrev { get; set; }

    public string? Ush { get; set; }

    public string? Area { get; set; }

    public string? NombreEmpleado { get; set; }

    public string? DescArea { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public string TipoTrafico { get; set; } = null!;

    public int? NumLlamadas { get; set; }

    public string UnidadMedida { get; set; } = null!;

    public double? Cantmedida { get; set; }

    public double? Importe { get; set; }
}
