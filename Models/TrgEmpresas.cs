using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgEmpresas
{
    public string Cif { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Domicilio { get; set; } = null!;

    public string CodPostal { get; set; } = null!;

    public string Localidad { get; set; } = null!;

    public string? CodEmpresa { get; set; }
}
