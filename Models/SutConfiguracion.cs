using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutConfiguracion
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Valor { get; set; }
}
