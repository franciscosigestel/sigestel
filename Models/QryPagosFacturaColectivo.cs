using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryPagosFacturaColectivo
{
    public int IdPago { get; set; }

    public int IdFactura { get; set; }

    public int? IdLinea { get; set; }

    public string? NumLinea { get; set; }

    public string TipoPago { get; set; } = null!;

    public string ConceptoPago { get; set; } = null!;

    public decimal? ImportePago { get; set; }

    public string? CodPago { get; set; }

    public int IdFacturaOrigenPago { get; set; }

    public short NumPago { get; set; }

    public short PlazosPago { get; set; }

    public short TotalPlazos { get; set; }

    public string? NumFactura { get; set; }
}
