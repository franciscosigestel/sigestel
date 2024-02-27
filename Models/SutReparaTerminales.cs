using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutReparaTerminales
{
    public int IdSolicitud { get; set; }

    public int? IdColectivo { get; set; }

    public int? IdUsuario { get; set; }

    public string? TelefonoContacto { get; set; }

    public string? TipoSolicitud { get; set; }

    public string? IdOperador { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? EstadoSolicitud { get; set; }

    public string? OrdenOperador { get; set; }

    public DateTime? FechaOrden { get; set; }

    public string? MedioOrden { get; set; }

    public DateTime? FechaRecogidaViejo { get; set; }

    public string? ObservacionesRecogida { get; set; }

    public DateTime? FechaRecepcionNuevo { get; set; }

    public string? ObservacionesRecepcion { get; set; }

    public DateTime? FechaEntregaNuevo { get; set; }

    public string? ObservacionesEntrega { get; set; }

    public string? TvMarca { get; set; }

    public string? TvModelo { get; set; }

    public string? TvImei { get; set; }

    public string? TvDesperfectos { get; set; }

    public string? TvBateria { get; set; }

    public string? TvCargador { get; set; }

    public string? TnMarca { get; set; }

    public string? TnModelo { get; set; }

    public string? TnImei { get; set; }

    public string? TnDesperfectos { get; set; }

    public string? TnBateria { get; set; }

    public string? TnCargador { get; set; }

    public decimal? TnCostePuntos { get; set; }

    public decimal? TnCosteEuros { get; set; }

    public short? TnPublicado { get; set; }

    public int? IdLinea { get; set; }

    public int? Permanencia { get; set; }

    public int? IdCompromiso { get; set; }

    public string? NombreCompromiso { get; set; }

    public string? DescCompromiso { get; set; }

    public DateTime? FechaDesdeCompromiso { get; set; }

    public DateTime? FechaHastaCompromiso { get; set; }

    public decimal? ImporteTotalCompromiso { get; set; }

    public decimal? TnCosteSubvencionPuntos { get; set; }

    public string? TipoOperadorCreador { get; set; }

    public string? HistoricoCambiosEstado { get; set; }

    public string? TarifaDatos { get; set; }

    public string? DireccionRecogida { get; set; }

    public string? CodPostalRecogida { get; set; }

    public string? PoblacionRecogida { get; set; }

    public string? ProvinciaRecogida { get; set; }

    public short? AvisadoSms { get; set; }

    public string? HistoricoComentarios { get; set; }

    public string? TvTerminal { get; set; }

    public string? TnTerminal { get; set; }

    public string? TerminalBotiquin { get; set; }

    public string? CargadorBotiquin { get; set; }

    public short? TerminalBotiquinPrestado { get; set; }

    public string? LugarRecogida { get; set; }

    public decimal? TnCosteEvfTotal { get; set; }

    public string? MotivoIncidencia { get; set; }

    public short? BloqReg { get; set; }

    public string? Fumr { get; set; }

    public int? BloqIdAdmin { get; set; }

    public short? TerminalFinanciado { get; set; }

    public int? IdfinanTf { get; set; }

    public int? NumAvisos { get; set; }

    public DateTime? FechaUltimoAviso { get; set; }

    public string? InfoAdicional { get; set; }

    public decimal? TnImporteMarginado { get; set; }

    public decimal? CostePvprenovePprecios { get; set; }

    public decimal? CosteColectivoRenovePprecios { get; set; }

    public int? NoCrearCompromisoRenove { get; set; }

    public int? RenovePpreciosPublicado { get; set; }

    public int? IdPlanPreciosPedidoRenove { get; set; }

    public decimal? CosteReparacion { get; set; }

    public short? TerminalIrreparable { get; set; }

    public DateTime? FechaTerminalIrreparable { get; set; }

    public short? FidelizacionEura { get; set; }

    public decimal? AdeudoCoopEura { get; set; }

    public decimal? DescuentoUsuarioEura { get; set; }

    public short? PermanenciaEura { get; set; }

    public string? PerfilUsuario { get; set; }
}
