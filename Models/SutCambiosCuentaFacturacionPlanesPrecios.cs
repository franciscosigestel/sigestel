using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutCambiosCuentaFacturacionPlanesPrecios
{
    public int IdRegistro { get; set; }

    public int IdLinea { get; set; }

    public int IdSocio { get; set; }

    public int IdColectivo { get; set; }

    public string? CuentaFactAntigua { get; set; }

    public string? CuentaFactNueva { get; set; }

    public string? PlanPreciosNuevo { get; set; }

    public decimal? PrecioNetoPlanPreciosNuevo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdAdminRegistro { get; set; }

    public DateTime? FechaEnvioVf { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public int? Ciclo { get; set; }

    public DateTime? FechaCambioCuentaFacturacion { get; set; }

    public int? IdTicket { get; set; }
}
