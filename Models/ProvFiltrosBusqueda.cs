using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvFiltrosBusqueda
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Valor { get; set; }

    public string? Pagina { get; set; }

    public string? Ambito { get; set; }

    public int? NivelAcceso { get; set; }
}
