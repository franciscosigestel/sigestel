using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutUsuarios
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Nif { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public int? IdCliente { get; set; }

    public string? InfoAdicional { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaModif { get; set; }

    public string? NombreBanco { get; set; }

    public string? NumCuenta { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? Usuario { get; set; }

    public string? Clave { get; set; }

    public int? CosteServicio { get; set; }

    public decimal? Franquicia { get; set; }

    public decimal? FranquiciaMax { get; set; }

    public decimal? SaldoPuntos { get; set; }

    public string? NumSocio { get; set; }

    public int? RecibirFacturaEmail { get; set; }

    public int? RecibirFacturaCorreoPostal { get; set; }

    public string? NumMovil { get; set; }

    public int? ExentoFacturacion { get; set; }

    public DateTime? FechaUltimaConexion { get; set; }

    public int ConexionesRealizadas { get; set; }

    public string? CuentaContable { get; set; }

    public string? TitularBanco { get; set; }

    public string? NiftitularBanco { get; set; }

    public short? NoPublicidad { get; set; }

    public string? RefOrdenDomiciliacion { get; set; }

    public DateTime? FechaOrdenDomiciliacion { get; set; }

    public string? PerfilUsuario { get; set; }

    public int? IduVinculado { get; set; }

    public short? BloqReg { get; set; }

    public string? Fumr { get; set; }

    public int? BloqIdAdmin { get; set; }

    public short? EmailVerificado { get; set; }

    public DateTime? FechaAceptacionRgpd { get; set; }

    public string? IpaceptacionRgpd { get; set; }

    public string? DatosNavegadorAceptacionRgpd { get; set; }

    public int? AsociacionPerfilUsuario { get; set; }

    public string? NivelRiesgo { get; set; }

    public DateTime? FechaNr { get; set; }

    public virtual Empresas? IdClienteNavigation { get; set; }

    public virtual ICollection<SutDireccionesUsuarios> SutDireccionesUsuarios { get; set; } = new List<SutDireccionesUsuarios>();

    public virtual ICollection<SutHistModifsUsuario> SutHistModifsUsuario { get; set; } = new List<SutHistModifsUsuario>();

    public virtual ICollection<SutLineas> SutLineas { get; set; } = new List<SutLineas>();

    public virtual ICollection<SutPeticionesIncidencias> SutPeticionesIncidencias { get; set; } = new List<SutPeticionesIncidencias>();
}
