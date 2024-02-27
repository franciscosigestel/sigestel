using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgTel977501020
{
    public string CodigoRegistro { get; set; } = null!;

    public string NSecuencial { get; set; } = null!;

    public string CodigoCliente { get; set; } = null!;

    public string RefAgrupacionFacturable { get; set; } = null!;

    public string CodAgrupacionDetalle { get; set; } = null!;

    public string TipoServicio { get; set; } = null!;

    public string CodMulticonexion { get; set; } = null!;

    public string NComercial1 { get; set; } = null!;

    public string NComercial2 { get; set; } = null!;

    public string Longitud { get; set; } = null!;

    public string CodigoConcepto { get; set; } = null!;

    public string RepeticionesConcepto { get; set; } = null!;

    public string? FacturaInterna { get; set; }
}
