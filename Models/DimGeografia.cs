using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimGeografia
{
    public int GeografiaKey { get; set; }

    public int? GeografiaPkey { get; set; }

    public string? GeografiaCod { get; set; }

    public string? GeografiaPcod { get; set; }

    public string? GeografiaDescripcion { get; set; }

    public string? GeografiaDireccion { get; set; }

    public bool? GeografiaAct { get; set; }
}
