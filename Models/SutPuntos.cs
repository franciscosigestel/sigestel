using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutPuntos
{
    public int IdOperacion { get; set; }

    public int? IdClienteUsuario { get; set; }

    public DateTime Fecha { get; set; }

    public decimal? ImportePuntos { get; set; }

    public string Tipo { get; set; } = null!;

    public string? DescOperacion { get; set; }

    public virtual ICollection<SutTerminales> SutTerminales { get; set; } = new List<SutTerminales>();
}
