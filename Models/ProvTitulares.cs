using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvTitulares
{
    public string Nif { get; set; } = null!;

    public string? NombreCompleto { get; set; }

    public string? TelefonoFijo { get; set; }

    public string? TelefonoMovil { get; set; }

    public int IdCliente { get; set; }

    public string? InfoAdicional { get; set; }

    public string? Direccion { get; set; }

    public string? Cp { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public short? Nuevo { get; set; }

    public string? PerfilUsuario { get; set; }
}
