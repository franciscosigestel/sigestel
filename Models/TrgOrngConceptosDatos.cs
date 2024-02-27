using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgOrngConceptosDatos
{
    public string NFactura { get; set; } = null!;

    public string NTelefono { get; set; } = null!;

    public string? Fecha { get; set; }

    public string? Servicio { get; set; }

    public string? PlanPrecio { get; set; }

    public string? Tipo { get; set; }

    public string? Franja { get; set; }

    public string? HoraEnvio { get; set; }

    public string? Volumen { get; set; }

    public string? Importe { get; set; }
}
