using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TiposServicio
{
    public string Codigo { get; set; } = null!;

    public int IdOperadora { get; set; }

    public int IdConcepto { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? Prorrateable { get; set; }

    public int? IdEmpresa { get; set; }
}
