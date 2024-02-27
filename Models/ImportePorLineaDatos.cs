using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ImportePorLineaDatos
{
    public string TipoServicio { get; set; } = null!;

    public string CodMulticonexion { get; set; } = null!;

    public string NComercial1 { get; set; } = null!;

    public string NComercial2 { get; set; } = null!;

    public string DomicilioTa { get; set; } = null!;

    public string PoblacionTa { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public string FechaAlta { get; set; } = null!;

    public string FechaBaja { get; set; } = null!;

    public double? Importe { get; set; }

    public DateTime? FechaFactura { get; set; }

    public string CodigoCliente { get; set; } = null!;
}
