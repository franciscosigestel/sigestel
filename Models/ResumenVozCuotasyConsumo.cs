using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ResumenVozCuotasyConsumo
{
    public string TipoServicio { get; set; } = null!;

    public string CodMulticonexion { get; set; } = null!;

    public string NComercial1 { get; set; } = null!;

    public string NComercial2 { get; set; } = null!;

    public string DomicilioTa { get; set; } = null!;

    public string PoblacionTa { get; set; } = null!;

    public string DomicilioTb { get; set; } = null!;

    public string PoblacionTb { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public string NombreProv { get; set; } = null!;

    public string FechaAlta { get; set; } = null!;

    public string FechaBaja { get; set; } = null!;

    public double? ImporteNeto { get; set; }

    public double? ImportePromociones { get; set; }

    public string? CodigoConcepto { get; set; }

    public double? Importe { get; set; }

    public double? Descuento { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public DateTime? FechaFactura { get; set; }

    public string? Descripcion { get; set; }

    public string CodigoCliente { get; set; } = null!;

    public string RefAgrupacionFacturable { get; set; } = null!;
}
