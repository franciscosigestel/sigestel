using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgMvstr310
{
    public string TipoRegistro { get; set; } = null!;

    public string SecuenciaRegistro { get; set; } = null!;

    public string Nfactura { get; set; } = null!;

    public string Nprefactura { get; set; } = null!;

    public string Ntelefono { get; set; } = null!;

    public string Nextension { get; set; } = null!;

    public string Finicio { get; set; } = null!;

    public string Ffin { get; set; } = null!;

    public string CodigoCuota { get; set; } = null!;

    public string DescripcionCuota { get; set; } = null!;

    public string Importe { get; set; } = null!;

    public string Libre { get; set; } = null!;

    public int? Cantidad { get; set; }
}
