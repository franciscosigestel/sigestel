using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvCompromisosLinea
{
    public int Id { get; set; }

    public int Idcolectivo { get; set; }

    public string NumTelefono { get; set; } = null!;

    public string Emisor { get; set; } = null!;

    public DateTime FechaHasta { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Importe { get; set; }

    public string Modo { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public DateTime FechaEstado { get; set; }
}
