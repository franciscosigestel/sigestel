using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class EmpresasAnexo
{
    public int IdEmpresa { get; set; }

    public string? Fidelizacion { get; set; }

    public decimal? BolsaEuroVf { get; set; }

    public decimal? EuroVfXLinea { get; set; }

    public short? Ciclo { get; set; }

    public string? CuentaVf { get; set; }

    public DateTime? FechaUltimaRenovacionContratoVf { get; set; }

    public short? DuracionMesesContratoVf { get; set; }

    public int? IdComercialvd { get; set; }

    public int? IdSoportevd { get; set; }

    public int? IdclienteGestCobro { get; set; }

    public string? ClaveRecibosc19 { get; set; }

    public short? CkMargenCoop { get; set; }

    public short? CkMargenHbdcoop { get; set; }

    public short? CkCosteCorreoPostal { get; set; }

    public short? CkTarifaPlanaGcu { get; set; }

    public short? CkCompilacionFacturas { get; set; }

    public short? CkCabeceraFacturable { get; set; }

    public short? CkFijosNacionalesGratis { get; set; }

    public decimal? PenalizacionBaja { get; set; }

    public short? ActivacionVbp { get; set; }

    public string? MovilCobroVbp { get; set; }

    public short? VfPack { get; set; }

    public short? PermiteSubcuentas { get; set; }

    public decimal? CuotaConsumoMinimoCoop { get; set; }

    public short? FinanciaTerminales { get; set; }

    public short? SgPack { get; set; }

    public short? RevendedorDe { get; set; }

    public short? AvisoxSms { get; set; }

    public short? AvisoxMail { get; set; }

    public string? AbreviaturasColectivo { get; set; }

    public string? MsgAltaUsuario { get; set; }

    public string? MsgAltaLinea { get; set; }

    public string? ParamsBranding { get; set; }

    public string? RestriccionesPorDefecto { get; set; }

    public string? RangoExt { get; set; }

    public string? CarpetaColectivo { get; set; }

    public string? PersonaContactoPosventas { get; set; }

    public string? TlfnoPersonaContactoPosventas { get; set; }

    public int? MargenPosventas { get; set; }

    public short? UsoAlias { get; set; }

    public short? NivelPosventa { get; set; }

    public short? CkFacturacionporLinea { get; set; }

    public short? ServFirmaManuscrita { get; set; }

    public short? CompromisoSustitucion { get; set; }

    public short? NotificarAvisosEmail { get; set; }

    public short? CicloAvancoop { get; set; }

    public short? FidelizacionEura { get; set; }

    public decimal? BolsaEura { get; set; }

    public short? ChkUsoApicambioSim { get; set; }
}
