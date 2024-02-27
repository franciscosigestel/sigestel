using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutHistPeticiones
{
    public int IdHistorial { get; set; }

    public int IdPeticion { get; set; }

    public int? IdAdminHis { get; set; }

    public string? Comentario { get; set; }

    public DateTime? FechaModif { get; set; }

    public string? Estado { get; set; }

    public string? TipoAlta { get; set; }

    public virtual SutAdministradores? IdAdminHisNavigation { get; set; }

    public virtual SutPeticionesIncidencias IdPeticionNavigation { get; set; } = null!;
}
