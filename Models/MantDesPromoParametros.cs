using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class MantDesPromoParametros
{
    public int IdDesPromoParametros { get; set; }

    public string CodigoDescPromo { get; set; } = null!;

    public string CodigoParametro { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string? Operadora { get; set; }

    public int? IdEmpresa { get; set; }
}
