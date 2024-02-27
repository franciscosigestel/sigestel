using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvPuntosPromo1
{
    public int Idoperacion { get; set; }

    public string NifUsuario { get; set; } = null!;

    public int Idcolectivo { get; set; }

    public DateTime FechaOperacion { get; set; }

    public int Cantidad { get; set; }

    public string? Comentario { get; set; }
}
