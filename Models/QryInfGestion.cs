using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryInfGestion
{
    public int? Id { get; set; }

    public string? Colectivo { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Linea { get; set; }

    public string Origen { get; set; } = null!;

    public string? Operador { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? TarifaDatos { get; set; }

    public string? DescTarifadatos { get; set; }

    public string? Vfijo { get; set; }

    public string? SFax { get; set; }

    public string? Direccion { get; set; }

    public string? CodPostal { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public string? Nif { get; set; }

    public string? NumCuenta { get; set; }

    public string? Email { get; set; }

    public string? PerfilUsuario { get; set; }
}
