using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvReferentes
{
    public string NifUsuarioNuevo { get; set; } = null!;

    public int IdcolectivoUsuarioNuevo { get; set; }

    public string? NifUsuarioReferente { get; set; }

    public int IdcolectivoUsuarioReferente { get; set; }

    public DateTime FechaAlta { get; set; }
}
