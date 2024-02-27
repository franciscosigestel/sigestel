using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgMvstr300
{
    public string TipoRegistro { get; set; } = null!;

    public string SecuenciaRegistro { get; set; } = null!;

    public string Nfactura { get; set; } = null!;

    public string Nprefactura { get; set; } = null!;

    public string Ntelefono { get; set; } = null!;

    public string Nextension { get; set; } = null!;

    public string TotalCuotas { get; set; } = null!;

    public string TotalServicioMedido { get; set; } = null!;

    public string TotalServicioFranq { get; set; } = null!;

    public string TotalVarios { get; set; } = null!;

    public string TotalDescuentos { get; set; } = null!;

    public string SumaTotal { get; set; } = null!;

    public string ProporcionCargos { get; set; } = null!;

    public string Cargos { get; set; } = null!;

    public string ProporcionDctoCuotas { get; set; } = null!;

    public string DescuentoCuotas { get; set; } = null!;

    public string ProporcionDctoServicio { get; set; } = null!;

    public string DescuentoServicio { get; set; } = null!;

    public string CodigoCc { get; set; } = null!;

    public string DescripcionCc { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Libre { get; set; } = null!;
}
