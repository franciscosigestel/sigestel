using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutResumenConcFactura
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

    public virtual SutFacturas IdFacturaNavigation { get; set; } = null!;
}
