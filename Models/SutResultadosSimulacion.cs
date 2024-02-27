using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutResultadosSimulacion
{
    public int Idauto { get; set; }

    public int? Idproceso { get; set; }

    public int? Idcolectivo { get; set; }

    public int? Idusuario { get; set; }

    public int? Idlinea { get; set; }

    public string? Numtelefono { get; set; }

    public string? Codatrb { get; set; }

    public string? Emisor { get; set; }

    public string? Codfacturacion { get; set; }

    public string? Texto { get; set; }

    public decimal? Importe { get; set; }

    public string? Fechadesde { get; set; }

    public string? Fechahasta { get; set; }
}
