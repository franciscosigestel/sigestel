using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryReparacionTerminalesExtend
{
    public int IdSolicitud { get; set; }

    public int? IdColectivo { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdLinea { get; set; }

    public string? Cif { get; set; }

    public string? Nombre { get; set; }

    public string? NumTelefono { get; set; }

    public string? TipoSolicitud { get; set; }

    public string? TvTerminal { get; set; }

    public string? TvBateria { get; set; }

    public string? TvCargador { get; set; }

    public string? TvMarcaModelo { get; set; }

    public string? TvImei { get; set; }

    public string? TvDesperfectos { get; set; }

    public string? TnMarcaModelo { get; set; }

    public string? TnImei { get; set; }

    public decimal? TnCostePuntos { get; set; }

    public decimal? TnCosteEuros { get; set; }

    public decimal? TnCosteSubvencionPuntos { get; set; }

    public decimal? TnCosteEvfTotal { get; set; }

    public decimal? MargenTerminal { get; set; }

    public string? HistoricoComentarios { get; set; }

    public string? EstadoSolicitud { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? OrdenOperador { get; set; }

    public string? LugarRecogida { get; set; }

    public string? DireccionRecogida { get; set; }

    public string? CodPostalRecogida { get; set; }

    public string? PoblacionRecogida { get; set; }

    public string? ProvinciaRecogida { get; set; }

    public string? NombreCompleto { get; set; }

    public string? TarifaDatos { get; set; }

    public string? NombreContactoComercial { get; set; }

    public string? Sfid { get; set; }
}
