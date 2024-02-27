using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutPagosFactura
{
    public int IdPago { get; set; }

    public int IdFactura { get; set; }

    public int? IdLinea { get; set; }

    public string? NumLinea { get; set; }

    /// <summary>
    /// Cuota Normal, Cuota Precipitada
    /// </summary>
    public string TipoPago { get; set; } = null!;

    public string ConceptoPago { get; set; } = null!;

    /// <summary>
    /// Total pago, impuestos incluidos (si lleva)
    /// </summary>
    public decimal ImportePago { get; set; }

    public string? CodPago { get; set; }

    public int IdFacturaOrigenPago { get; set; }

    /// <summary>
    /// Numero de orden del pago
    /// </summary>
    public short NumPago { get; set; }

    /// <summary>
    /// Numero de plazos incluidos en el pago (por ej. al precipitar)
    /// </summary>
    public short PlazosPago { get; set; }

    /// <summary>
    /// Total de Plazos
    /// </summary>
    public short TotalPlazos { get; set; }
}
