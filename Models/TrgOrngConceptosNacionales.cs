using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgOrngConceptosNacionales
{
    public string NFactura { get; set; } = null!;

    public string NTelefono { get; set; } = null!;

    public string? Fecha { get; set; }

    public string? NumeroDestino { get; set; }

    public string? DestinoOperador { get; set; }

    public string? Tarifa { get; set; }

    public string? Tipo { get; set; }

    public string? Franja { get; set; }

    public string? Inicio { get; set; }

    public string? Duracion { get; set; }

    public string? Importe { get; set; }
}
