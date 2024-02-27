using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutAsociacionesPerfilUsuario
{
    public int Id { get; set; }

    public string? Cif { get; set; }

    public string? RazonSocial { get; set; }

    public string? NombreComercial { get; set; }

    public string? Direccion { get; set; }

    public string? Cp { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public string? TlfnoContacto { get; set; }

    public string? PersonaContacto { get; set; }

    public string? EmailContacto { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? PerfilUsuario { get; set; }

    public short? NotificarAvisosEmail { get; set; }

    public string? AtrbuserOpc { get; set; }

    public string? TextoAviso { get; set; }
}
