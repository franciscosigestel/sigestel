using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimUnidadesGestion
{
    public int GestionKey { get; set; }

    public int? GestionPkey { get; set; }

    public string? GestionCod { get; set; }

    public string? GestionPcod { get; set; }

    public string? GestionNombre { get; set; }

    public string? GestionDescripcion { get; set; }

    public int? GestionNivel { get; set; }

    public string? GestionUsuarioRed { get; set; }

    public bool? GestionAct { get; set; }
}
