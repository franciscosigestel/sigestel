using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvPeticionesIncidencias
{
    public int IdPeticion { get; set; }

    public int IdAdminPet { get; set; }

    public int IdClientePet { get; set; }

    public int IdLineaProlin { get; set; }

    public int? TipoPeticion { get; set; }

    public string? Asunto { get; set; }

    public string? Mensaje { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? ComentarioCierre { get; set; }

    public string? Prioridad { get; set; }

    public int? IdOperadorAsignado { get; set; }

    public int IdUsuarioProlin { get; set; }
}
