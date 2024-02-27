using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class Usuarios
{
    public string Usuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string IdEmpleado { get; set; } = null!;

    public int IdGrupo { get; set; }
}
