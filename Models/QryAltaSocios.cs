using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryAltaSocios
{
    public string Nif { get; set; } = null!;

    public string? NombreUsuario { get; set; }

    public string? Email { get; set; }

    public int IdCliente { get; set; }

    public string? InfoAdicional { get; set; }

    public string? NombreBanco { get; set; }

    public string? NumCuenta { get; set; }

    public string? TitularBanco { get; set; }

    public string? NiftitularBanco { get; set; }

    public string? NumSocio { get; set; }

    public string? Direccion { get; set; }

    public string? Cp { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public short? NoPublicidad { get; set; }

    public string? Nombre { get; set; }

    public string? Cif { get; set; }

    public string? NombreAdminLegal { get; set; }

    public string? DniAdminLegal { get; set; }

    public int? CodigoOperador { get; set; }

    public string? NumTelefono { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? Operador { get; set; }

    public string? OrigenLinea { get; set; }

    public string? Comentarios { get; set; }

    public string? LimiteConsumo { get; set; }

    public string? SimDonante { get; set; }

    public short? Datos { get; set; }

    public string? TarifaDatos { get; set; }

    public double? CosteDatos { get; set; }

    public short? Vodafonefijo { get; set; }

    public string? NumVf { get; set; }

    public string? Terminal { get; set; }

    public string? NifTitular { get; set; }

    public string? Estado { get; set; }

    public string? NombreTitular { get; set; }

    public decimal? CosteTerminalPvp { get; set; }

    public decimal? ImporteFianza { get; set; }

    public string? OtrosServicios { get; set; }

    public string? Restricciones { get; set; }

    public int? ImporteLimiteConsumo { get; set; }

    public string? PoblacionEmpresa { get; set; }

    public short? TerminalFinanciado { get; set; }

    public int? IdfinanTf { get; set; }

    public string? PerfilUsuario { get; set; }

    public int? AsociacionPerfilUsuario { get; set; }
}
