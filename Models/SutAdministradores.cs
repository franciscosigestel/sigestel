using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutAdministradores
{
    public int IdAdministrador { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string? Clave { get; set; }

    public int? IdCliente { get; set; }

    public string Email { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? Telefono { get; set; }

    public int? IdPerfil { get; set; }

    public string? Nif { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public int? ReenvioEmail { get; set; }

    public DateTime? FechaUltimaConexion { get; set; }

    public int ConexionesRealizadas { get; set; }

    public DateTime? FechaAceptacionRgpd { get; set; }

    public string? IpaceptacionRgpd { get; set; }

    public string? DatosNavegadorRgpd { get; set; }

    public short? EmailVerificado { get; set; }

    public string? TelefonoAgente { get; set; }

    public string? Idagente { get; set; }

    public string? PerfilUsuario { get; set; }

    public int? AsociacionPerfilUsuario { get; set; }

    public virtual Empresas? IdClienteNavigation { get; set; }

    public virtual SutPerfiles? IdPerfilNavigation { get; set; }

    public virtual ICollection<SutHistModifsUsuario> SutHistModifsUsuario { get; set; } = new List<SutHistModifsUsuario>();

    public virtual ICollection<SutHistPeticiones> SutHistPeticiones { get; set; } = new List<SutHistPeticiones>();

    public virtual ICollection<SutPeticionesIncidencias> SutPeticionesIncidencias { get; set; } = new List<SutPeticionesIncidencias>();
}
