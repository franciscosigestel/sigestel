using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class CfDetmvCobrointernas
{
    public string FactNo { get; set; } = null!;

    public string TelefExt { get; set; } = null!;

    public string FechaHora { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string NoRecep { get; set; } = null!;

    public decimal? ImporteNeto { get; set; }

    public string Telef2 { get; set; } = null!;
}
