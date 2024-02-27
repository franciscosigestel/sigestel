using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimTarifa
{
    public int TarifaKey { get; set; }

    public int? TarifaPkey { get; set; }

    public string? TarifaCod { get; set; }

    public string? TarifaPcod { get; set; }

    public string? TarifaDescripcion { get; set; }
}
