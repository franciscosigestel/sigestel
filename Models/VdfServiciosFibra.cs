using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class VdfServiciosFibra
{
    public string? IdCliente { get; set; }

    public decimal? Instancia { get; set; }

    public string? CodigoServicio { get; set; }

    public string? DescripcionServicio { get; set; }

    public string? TelefonoAsociado { get; set; }

    public decimal? Precio { get; set; }

    public DateTime? FechaInstalacion { get; set; }

    public DateTime? FechaDesinstalacion { get; set; }

    public string? EstadoCrm { get; set; }

    public string? Rgu { get; set; }

    public string? Paquete { get; set; }

    public string? FechaGrabacion { get; set; }
}
