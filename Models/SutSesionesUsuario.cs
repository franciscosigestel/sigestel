using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutSesionesUsuario
{
    public int Id { get; set; }

    public int Idusuario { get; set; }

    public string TipoUsuario { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? Idcliente { get; set; }

    public DateTime? FechaUltimaActividad { get; set; }

    public string? UltimaPaginaVisitada { get; set; }

    public string? IpConexion { get; set; }
}
