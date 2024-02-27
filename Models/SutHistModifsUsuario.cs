using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutHistModifsUsuario
{
    public int IdHistoricoUsuario { get; set; }

    public int? IdAdminHis { get; set; }

    public int IdUsuarioHis { get; set; }

    public string Cambios { get; set; } = null!;

    public DateTime FechaModif { get; set; }

    public string? TipoModif { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public int? IdAdminCierre { get; set; }

    public virtual SutAdministradores? IdAdminHisNavigation { get; set; }

    public virtual SutUsuarios IdUsuarioHisNavigation { get; set; } = null!;
}
