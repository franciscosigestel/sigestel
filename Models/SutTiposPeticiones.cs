using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutTiposPeticiones
{
    public int IdTipoPeticion { get; set; }

    public string Nombre { get; set; } = null!;

    public int? Admin { get; set; }

    public int? Operador { get; set; }

    public int? Usuario { get; set; }

    public string? AsignacionPerfil { get; set; }

    public string? ReenvioPerfil { get; set; }

    public string? DatosObligatorios { get; set; }

    public string? Plantilla { get; set; }

    public string? Estado { get; set; }
}
