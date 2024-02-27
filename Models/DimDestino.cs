using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimDestino
{
    public int DestinoKey { get; set; }

    public int? DestinoPkey { get; set; }

    public string? DestinoCod { get; set; }

    public string? DestinoPcod { get; set; }

    public string? DestinoDescripcion { get; set; }
}
