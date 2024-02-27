using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvMargenHbd
{
    public int Idmargen { get; set; }

    public int Idcolectivo { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Codtarifa { get; set; }

    public string LiteralHbd { get; set; } = null!;

    public decimal MargenHbd { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? Fechaalta { get; set; }

    public string? Estado { get; set; }

    public DateTime? Fechaestado { get; set; }

    public decimal Limiteinf { get; set; }

    public decimal Limitesup { get; set; }

    public string? PerfilUsuario { get; set; }
}
