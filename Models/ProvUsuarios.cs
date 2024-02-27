using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvUsuarios
{
    public string Nif { get; set; } = null!;

    public string? NombreCompleto { get; set; }

    public string? TelefonoFijo { get; set; }

    public string? TelefonoMovil { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public short? RecibirFacturaEmail { get; set; }

    public short? RecibirFacturaCorreoPostal { get; set; }

    public int IdCliente { get; set; }

    public string? InfoAdicional { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaModif { get; set; }

    public string? NombreBanco { get; set; }

    public string? NumCuenta { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? NumSocio { get; set; }

    public string? Direccion { get; set; }

    public string? Cp { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public int? IdServidor { get; set; }

    public string? EstadoSincro { get; set; }

    public DateTime? FechaEstadoSincro { get; set; }

    public short? Nuevo { get; set; }

    public string? TitularBanco { get; set; }

    public string? NiftitularBanco { get; set; }

    public short? NoPublicidad { get; set; }

    public string? RefOrdenDomiciliacion { get; set; }

    public DateTime? FechaOrdenDomiciliacion { get; set; }

    public string? PerfilUsuario { get; set; }

    public short? BloqReg { get; set; }

    public string? Fumr { get; set; }

    public int? BloqIdAdmin { get; set; }

    public short? EmailVerificado { get; set; }

    public int? AsociacionPerfilUsuario { get; set; }

    public string? CuentaContable { get; set; }

    public string? NivelRiesgo { get; set; }

    public DateTime? FechaNr { get; set; }

    public int IdUsuarioProlin { get; set; }
}
