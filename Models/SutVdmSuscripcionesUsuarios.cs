using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutVdmSuscripcionesUsuarios
{
    public int IdSuscripcion { get; set; }

    public int IdEdicion { get; set; }

    public string? IdClienteVdm { get; set; }

    public string? IdCuenta { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime FechaEstado { get; set; }

    public int? TotalUnidadesActivas { get; set; }

    public string? CifAutorizado { get; set; }

    public string? EmailAutorizado { get; set; }

    public string? NombreAutorizado { get; set; }

    public string? MovilAutorizado { get; set; }

    public string? NombreEmpresaAutorizado { get; set; }

    public string? RazonSocialAutorizado { get; set; }

    public string? DatosCreador { get; set; }
}
