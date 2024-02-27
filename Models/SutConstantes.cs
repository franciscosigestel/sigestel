using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutConstantes
{
    public int IdConstante { get; set; }

    public string Nombre { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public string? Descripcion { get; set; }

    public short? CodOperador { get; set; }
}
