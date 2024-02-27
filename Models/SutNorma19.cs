using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutNorma19
{
    public int Idregistro { get; set; }

    public string? NombreOrdenante { get; set; }

    public string? CifOrdenante { get; set; }

    public string? SufijoOrdenante { get; set; }

    public string? NumCuentaOrdenante { get; set; }

    public string? NombreColectivo { get; set; }

    public string? NombreSocio { get; set; }

    public string? NifSocio { get; set; }

    public string? NumCuentaSocio { get; set; }

    public string? FactOtm { get; set; }

    public string? NumFactura { get; set; }

    public decimal? TotalFactura { get; set; }

    public decimal? SumatorioTotalFactura { get; set; }

    public string? DireccionFactura { get; set; }

    public string? PoblacionFactura { get; set; }

    public string? CodPostalFactura { get; set; }

    public int? IdFactura { get; set; }

    public string? Bicacreedor { get; set; }

    public string? RefMandato { get; set; }

    public DateTime? FechaMandato { get; set; }

    public int? IdUsuario { get; set; }

    public string? TipoRecibo { get; set; }

    public int? NumPago { get; set; }
}
