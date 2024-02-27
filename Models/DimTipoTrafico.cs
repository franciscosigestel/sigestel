using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimTipoTrafico
{
    public int TraficoKey { get; set; }

    public int? TraficoPkey { get; set; }

    public string? TraficoCod { get; set; }

    public string? TraficoPcod { get; set; }

    public string? TraficoDescripcion { get; set; }
}
