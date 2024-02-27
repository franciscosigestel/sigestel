using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutCatalogoServicios
{
    public int IdCatServ { get; set; }

    public int CodOper { get; set; }

    public int IdCliente { get; set; }

    public int TipoActivacion { get; set; }

    public string CodServicio { get; set; } = null!;

    public string? CodServicioOper { get; set; }

    public string CatServicio { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Literal { get; set; }

    public int ParametrosActivacion { get; set; }

    public string? Parametros { get; set; }

    public decimal? ImporteBrutoOperadorAlta { get; set; }

    public decimal? ImporteBrutoOperador { get; set; }

    public string? TipoDeCobro { get; set; }

    public decimal? DtoColectivo { get; set; }

    public decimal? ImporteNetoUsuario { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaEstado { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? AtribOpcAlta { get; set; }

    public string? ServIncomp { get; set; }

    public int? CompromisoPermanencia { get; set; }

    public string? TipoPermanencia { get; set; }

    public decimal? ImportePermanencia { get; set; }

    public string? InfoTramites { get; set; }

    public int? MesesPermanencia { get; set; }

    public string? PlanespreciosDepen { get; set; }

    public string? PerfilUsuario { get; set; }

    public string? CodPenalizacion { get; set; }

    public DateTime? FechaHasta { get; set; }
}
