using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutDetalleTelefonoFactura
{
    public int IdDetalle { get; set; }

    public int IdFactura { get; set; }

    public string NumTelefono { get; set; } = null!;

    public string TipoDetalle { get; set; } = null!;

    public string? FechaHora { get; set; }

    public string? Destino { get; set; }

    public string? NumTelefRecep { get; set; }

    public string? Tarifa { get; set; }

    public decimal? VolumenDatos { get; set; }

    public decimal? DuracionLlamada { get; set; }

    public decimal? Importe { get; set; }

    public decimal? ImporteNeto { get; set; }

    public int? IdLinea { get; set; }

    public string? FechaDesde { get; set; }

    public string? FechaHasta { get; set; }

    public string? Emisor { get; set; }

    public virtual SutFacturas IdFacturaNavigation { get; set; } = null!;
}
