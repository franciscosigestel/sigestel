using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class InventarioVozcuotas
{
    public string TipoServicio { get; set; } = null!;

    public string DescTipoServ { get; set; } = null!;

    public string CodMulticonexion { get; set; } = null!;

    public string NComercial1 { get; set; } = null!;

    public string NComercial2 { get; set; } = null!;

    public string CodProdConcepFact { get; set; } = null!;

    public string DescConFact { get; set; } = null!;

    public double? Importe { get; set; }

    public DateTime? FechaFactura { get; set; }

    public string? FacturaInterna { get; set; }

    public string NSecuencial { get; set; } = null!;

    public string DomicilioTa { get; set; } = null!;

    public string PoblacionTa { get; set; } = null!;

    public string DomicilioTb { get; set; } = null!;

    public string PoblacionTb { get; set; } = null!;

    public double? ImpUnitario { get; set; }

    public int? Nunidades { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public string CodigoConcepto { get; set; } = null!;

    public string? Empresa { get; set; }
}
