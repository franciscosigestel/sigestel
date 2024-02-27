using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class InventarioVozCuotasV2
{
    public string TipoServicio { get; set; } = null!;

    public string CodMulticonexion { get; set; } = null!;

    public string NComercial1 { get; set; } = null!;

    public string NComercial2 { get; set; } = null!;

    public string? FacturaInterna { get; set; }

    public string DomicilioTa { get; set; } = null!;

    public string PoblacionTa { get; set; } = null!;

    public string DomicilioTb { get; set; } = null!;

    public string PoblacionTb { get; set; } = null!;

    public string CodigoConcepto { get; set; } = null!;

    public string CodProdConcepFact { get; set; } = null!;

    public double? Importe { get; set; }

    public string Descripcion { get; set; } = null!;

    public double? Descuento { get; set; }

    public string? Fecha { get; set; }

    public string FechaAlta { get; set; } = null!;

    public string FechaBaja { get; set; } = null!;

    public string? Empresa { get; set; }

    public string RefAgrupacionFacturable { get; set; } = null!;

    public string NSecuencial { get; set; } = null!;
}
