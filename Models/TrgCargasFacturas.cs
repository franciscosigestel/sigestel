using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgCargasFacturas
{
    public int IdCarga { get; set; }

    public string CodFactura { get; set; } = null!;

    public DateTime? FechaFactura { get; set; }

    public byte? CargadoDw { get; set; }

    public int? IdEmpresa { get; set; }
}
