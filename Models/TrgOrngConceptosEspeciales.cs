using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgOrngConceptosEspeciales
{
    public string NFactura { get; set; } = null!;

    public string NTelefono { get; set; } = null!;

    public string? Fecha { get; set; }

    public string? NDestino { get; set; }

    public string? TipoServicio { get; set; }

    public string? Proveedor { get; set; }

    public string? CifProveedor { get; set; }

    public string? Concepto { get; set; }

    public string? Inicio { get; set; }

    public string? DuracionVolumen { get; set; }

    public string? Importe { get; set; }
}
