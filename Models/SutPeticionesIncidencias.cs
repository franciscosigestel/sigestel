using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutPeticionesIncidencias
{
    public int IdPeticion { get; set; }

    public int? IdAdminPet { get; set; }

    public int? IdClientePet { get; set; }

    public int? IdUsuarioPet { get; set; }

    public int? IdLinea { get; set; }

    public int? IdServicio { get; set; }

    public int? IdTerminal { get; set; }

    public int? TipoPeticion { get; set; }

    public string? Asunto { get; set; }

    public string? Mensaje { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public string? ComentarioCierre { get; set; }

    public string? IdPerfilAdminsDestinatarios { get; set; }

    public string? TipoAlta { get; set; }

    public string? Prioridad { get; set; }

    public int? IdOperadorAsignado { get; set; }

    public string? CompromisosAsociados { get; set; }

    public string? InfoTramites { get; set; }

    public virtual SutAdministradores? IdAdminPetNavigation { get; set; }

    public virtual Empresas? IdClientePetNavigation { get; set; }

    public virtual SutLineas? IdLineaNavigation { get; set; }

    public virtual SutServicios? IdServicioNavigation { get; set; }

    public virtual SutUsuarios? IdUsuarioPetNavigation { get; set; }

    public virtual ICollection<SutFichAdjuntos> SutFichAdjuntos { get; set; } = new List<SutFichAdjuntos>();

    public virtual ICollection<SutHistPeticiones> SutHistPeticiones { get; set; } = new List<SutHistPeticiones>();
}
