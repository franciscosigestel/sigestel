using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgCompromisos
{
    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Compromiso { get; set; } = null!;

    public int? Idoperadora { get; set; }

    public int? Idempresa { get; set; }
}
