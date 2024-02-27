using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryInfProvision
{
    public int? Id { get; set; }

    public string? Colectivo { get; set; }

    public string Linea { get; set; } = null!;

    public string? Origen { get; set; }

    public string? Operador { get; set; }

    public string? NifUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? TarifaDatos { get; set; }

    public string? Terminal { get; set; }

    public short? TerminalFinanciado { get; set; }

    public string? Email { get; set; }

    public string? PerfilUsuario { get; set; }

    public string? Direccion { get; set; }

    public string? Cp { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public string? NumCuenta { get; set; }
}
