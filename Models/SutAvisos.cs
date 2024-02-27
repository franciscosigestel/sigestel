using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutAvisos
{
    public int Idaviso { get; set; }

    public int? Idcolectivo { get; set; }

    public int? Idusuario { get; set; }

    public DateTime? FechaHasta { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? Mensaje { get; set; }

    public int? Idoperador { get; set; }
}
