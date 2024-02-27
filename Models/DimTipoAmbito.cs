using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimTipoAmbito
{
    public int AmbitoKey { get; set; }

    public int? AmbitoPkey { get; set; }

    public string? AmbitoCod { get; set; }

    public string? AmbitoPcod { get; set; }

    public string? AmbitoDescripcion { get; set; }
}
