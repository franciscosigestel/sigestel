using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvRcatalogoTerminal
{
    public int Id { get; set; }

    public int IdCat { get; set; }

    public int IdTerm { get; set; }

    public int IdColectivo { get; set; }

    public string? CodTarifa { get; set; }

    public string? DescTarifa { get; set; }

    public string? VolDatosTarifa { get; set; }

    public decimal? PrecioNetoTarifa { get; set; }

    public decimal? PrecioCosteTarifa { get; set; }

    public decimal? PrecioCosteTerminal { get; set; }

    public decimal? PrecioPvpterminal { get; set; }

    public int? Orden { get; set; }

    public decimal? PrecioCosteTerminalUpload { get; set; }

    public decimal? PrecioPvpterminalUpload { get; set; }

    public string? PerfilUsuario { get; set; }

    public short? Promocionado { get; set; }

    public string? CuentaVf { get; set; }

    public string? CodtarifaOperador { get; set; }
}
