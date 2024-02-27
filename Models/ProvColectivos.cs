using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvColectivos
{
    public string Cif { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaModif { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public int? CodigoOperador { get; set; }

    public string? NombreBanco { get; set; }

    public string? NumCuenta { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public int? CosteServicio { get; set; }

    public decimal? Franquicia { get; set; }

    public decimal? MargenColectivo { get; set; }

    public string? Direccion { get; set; }

    public string? Cp { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public int? IdServidor { get; set; }

    public string? EstadoSincro { get; set; }

    public DateTime? FechaEstadoSincro { get; set; }

    public string? NombreAdminLegal { get; set; }

    public string? DniAdminLegal { get; set; }

    public short? Nuevo { get; set; }

    public int? IdGrupo { get; set; }
}
