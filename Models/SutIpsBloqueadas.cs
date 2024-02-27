using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutIpsBloqueadas
{
    public int Id { get; set; }

    public string DireccionIp { get; set; } = null!;

    public string UsuarioConexion { get; set; } = null!;

    public DateTime FechaUltimoAcceso { get; set; }
}
