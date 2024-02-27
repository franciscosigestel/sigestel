using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class MovilCosteporLinea
{
    public DateTime? FechaFactura { get; set; }

    public string Ntelefono { get; set; } = null!;

    public string Nextension { get; set; } = null!;

    public double? Cuota { get; set; }

    public double? ServicioMedido { get; set; }

    public double? Varios { get; set; }

    public double? Descuentos { get; set; }

    public double? Total { get; set; }

    public double? Promocion { get; set; }

    public double? Cargo { get; set; }

    public double? PromocionDto { get; set; }

    public double? DtoCuotas { get; set; }

    public double? DtoServicio { get; set; }

    public string Cif { get; set; } = null!;
}
