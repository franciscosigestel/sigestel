using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class VdfComprasFibra
{
    public string? IdCliente { get; set; }

    public string? NumeroSerie { get; set; }

    public string? TipoEvento { get; set; }

    public DateTime FechaEvento { get; set; }

    public TimeOnly? HoraEvento { get; set; }

    public string? Descripcion { get; set; }

    public decimal? ImporteBase { get; set; }

    public decimal? ImporteDescuento { get; set; }

    public decimal? ImporteTotal { get; set; }

    public string? FechaGrabacion { get; set; }
}
