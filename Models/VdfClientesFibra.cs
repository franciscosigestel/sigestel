using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class VdfClientesFibra
{
    public string? IdCliente { get; set; }

    public string? EstadoCliente { get; set; }

    public string? Direccion { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Ciudad { get; set; }

    public string? Provincia { get; set; }

    public string? FechaGrabacion { get; set; }
}
