using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class MantDescPromo
{
    public int IdOperadora { get; set; }

    public int IdConcepto { get; set; }

    public string Codigo { get; set; } = null!;

    public string TipoAsociacion { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public double Importe { get; set; }

    public string Inicio { get; set; } = null!;

    public string Fin { get; set; } = null!;

    public string? AgrupaConcepto { get; set; }

    public int IdEmpresa { get; set; }
}
