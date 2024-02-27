using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvTiposPeticiones
{
    public int IdTipoPeticion { get; set; }

    public string Nombre { get; set; } = null!;

    public string? DatosObligatorios { get; set; }

    public string? Plantilla { get; set; }

    public string? Estado { get; set; }
}
