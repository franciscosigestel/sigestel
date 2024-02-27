using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryServiciosDatos
{
    public int IdServicio { get; set; }

    public int IdLinea { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }

    public string? Tipo { get; set; }
}
