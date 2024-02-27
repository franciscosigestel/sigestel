using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class CfResumenTelf
{
    public string? Titular { get; set; }

    public string? Ciclo { get; set; }

    public string? Telef { get; set; }

    public decimal? CuotaMes { get; set; }

    public decimal? OtrasCuot { get; set; }

    public decimal? Consumo { get; set; }

    public decimal? Descuentos { get; set; }

    public decimal? OtrosAb { get; set; }

    public decimal? OtrosCar { get; set; }

    public decimal? Total { get; set; }

    public string? Cuenta { get; set; }

    public int? MsmvCant { get; set; }

    public decimal? MsmvEuros { get; set; }

    public int? MsmnvCant { get; set; }

    public decimal? MsmnvEuros { get; set; }

    public int? MsintCant { get; set; }

    public decimal? MsintEuros { get; set; }

    public int? TotalCantidad { get; set; }

    public decimal? TotalEuros { get; set; }

    public string? CuentaNo { get; set; }
}
