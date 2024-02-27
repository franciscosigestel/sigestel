using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class LineasTelefonoCuotas
{
    public int Id { get; set; }

    public string Nfactura { get; set; } = null!;

    public string Ntelefono { get; set; } = null!;

    public string? Cuotas { get; set; }

    public int? AcuerdosMarcoVirtuales { get; set; }
}
