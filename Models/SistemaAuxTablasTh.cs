using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SistemaAuxTablasTh
{
    public string? TablaTh { get; set; }

    public string? StrSql { get; set; }

    public string Accion { get; set; } = null!;

    public int? Orden { get; set; }

    public int? Operador { get; set; }

    public byte? EsDetalle { get; set; }

    public int? TipoCarga { get; set; }
}
