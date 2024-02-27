using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimUnidadMedida
{
    public int MedidaKey { get; set; }

    public int? MedidaPkey { get; set; }

    public string? MedidaCod { get; set; }

    public string? MedidaPcod { get; set; }

    public string? MedidaDescripcion { get; set; }
}
