using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class NlineasVoz
{
    public string TipoServicio { get; set; } = null!;

    public string NComercial1 { get; set; } = null!;

    public string? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public double? Importe { get; set; }
}
