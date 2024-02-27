using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutAccesosFallidos
{
    public int Id { get; set; }

    public string DireccionIp { get; set; } = null!;

    public string UsuarioConexion { get; set; } = null!;

    public DateTime Fecha { get; set; }
}
