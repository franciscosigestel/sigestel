using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgCargas
{
    public string FechaCarga { get; set; } = null!;

    public string Operador { get; set; } = null!;

    public string NombreFichero { get; set; } = null!;

    public string EstadoCarga { get; set; } = null!;

    public int IdCarga { get; set; }

    public int? Idempresa { get; set; }
}
