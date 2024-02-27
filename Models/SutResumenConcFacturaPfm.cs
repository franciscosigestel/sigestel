using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutResumenConcFacturaPfm
{
    public int IdConcepto { get; set; }

    public int IdFactura { get; set; }

    public string? NombreConcepto { get; set; }

    public string? TipoConcepto { get; set; }

    public decimal Importe { get; set; }

    public decimal Descuento { get; set; }

    public decimal ImporteNeto { get; set; }

    public string? CodConcepto { get; set; }

    public int? IdLinea { get; set; }

    public virtual SutFacturasPfm IdFacturaNavigation { get; set; } = null!;
}
