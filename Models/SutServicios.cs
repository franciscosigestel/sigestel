using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutServicios
{
    public int IdServicio { get; set; }

    public int IdLinea { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? Tipo { get; set; }

    public decimal? CosteMensual { get; set; }

    public int? IdAdminCreador { get; set; }

    public string? Comentarios { get; set; }

    public int? IdColectivo { get; set; }

    public string? ServIncomp { get; set; }

    public string? AtribOpcAlta { get; set; }

    public decimal? CosteAlta { get; set; }

    public decimal? CosteColectivo { get; set; }

    public string? TipoPermanencia { get; set; }

    public decimal? ImportePermanencia { get; set; }

    public int? MesesPermanencia { get; set; }

    public string? Parametros { get; set; }

    public short? TipoActivacion { get; set; }

    public string? PerfilUsuario { get; set; }

    public string? CodPenalizacion { get; set; }

    public virtual SutLineas IdLineaNavigation { get; set; } = null!;

    public virtual ICollection<SutCompromisos> SutCompromisos { get; set; } = new List<SutCompromisos>();

    public virtual ICollection<SutPeticionesIncidencias> SutPeticionesIncidencias { get; set; } = new List<SutPeticionesIncidencias>();
}
