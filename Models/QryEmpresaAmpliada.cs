using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryEmpresaAmpliada
{
    public int Id { get; set; }

    public string? Cif { get; set; }

    public string? Nombre { get; set; }

    public int? CodigoOperador { get; set; }

    public short? Ciclo { get; set; }

    public string? CuentaVf { get; set; }

    public string? Poblacion { get; set; }

    public string? Nombrevd { get; set; }

    public string? Sfid { get; set; }

    public int? Ultimaextension { get; set; }

    public int? IdcVinculada { get; set; }

    public string? RangoExt { get; set; }

    public short? RevendedorDe { get; set; }

    public short? FinanciaTerminales { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaUltimaRenovacionContratoVf { get; set; }
}
