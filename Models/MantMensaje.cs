using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class MantMensaje
{
    public int Id { get; set; }

    public string CodigoOperadora { get; set; } = null!;

    public string CodigoTipoMensaje { get; set; } = null!;

    public string? RangoDesde { get; set; }

    public string? RangoHasta { get; set; }

    public string? Precio { get; set; }

    public int? IdEmpresa { get; set; }
}
