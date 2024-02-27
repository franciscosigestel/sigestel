using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgOrngCabeceraFactura
{
    public string NFactura { get; set; } = null!;

    public string? FFactura { get; set; }

    public string? PFacturado { get; set; }

    public string? NombreCliente { get; set; }

    public string? DirCliente { get; set; }

    public string? NifCif { get; set; }

    public string? MetPago { get; set; }

    public string? EntFinanciera { get; set; }

    public string? Ccorriente { get; set; }

    public string? PagoApartir { get; set; }

    public string? DirContacto { get; set; }

    public string? CargosImporte { get; set; }

    public string? ConsLlamadas { get; set; }

    public string? ConsMenServDat { get; set; }

    public string? ConsServEsp { get; set; }

    public string? CargosBajoCons { get; set; }

    public string? OtrosCargos { get; set; }

    public string? TotalCargos { get; set; }

    public string? Total { get; set; }

    public string? TotalAntesI { get; set; }

    public string? Iva { get; set; }

    public string? TotalPagar { get; set; }
}
