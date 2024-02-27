using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgMvstr700
{
    public string TipoRegistro { get; set; } = null!;

    public string SecuenciaRegistro { get; set; } = null!;

    public string Nfactura { get; set; } = null!;

    public string Nprefactura { get; set; } = null!;

    public string Ntelefono { get; set; } = null!;

    public string Nextension { get; set; } = null!;

    public string CodigoCargo { get; set; } = null!;

    public string DescCargo { get; set; } = null!;

    public string Importe { get; set; } = null!;

    public string Libre { get; set; } = null!;
}
