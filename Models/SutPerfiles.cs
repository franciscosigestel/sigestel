using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutPerfiles
{
    public int IdPerfil { get; set; }

    public string NombrePerfil { get; set; } = null!;

    public int Nivel { get; set; }

    public string? Descripcion { get; set; }

    public int? EsOperador { get; set; }

    public virtual ICollection<SutAdministradores> SutAdministradores { get; set; } = new List<SutAdministradores>();
}
