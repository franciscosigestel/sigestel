using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutGrupos
{
    public int IdGrupo { get; set; }

    public string? Cif { get; set; }

    public string? RazonSocial { get; set; }

    public string? Direccion { get; set; }

    public string? Cp { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? InfoAdicional { get; set; }

    public string? Banco { get; set; }

    public string? NumCuenta { get; set; }

    public string? Iniciales { get; set; }

    public int? IdCabeceraGrupo { get; set; }
}
