using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvLineas
{
    public string NumTelefono { get; set; } = null!;

    public string? Extension { get; set; }

    public string? NifTitular { get; set; }

    public string? NifUsuario { get; set; }

    public int IdCliente { get; set; }

    public string? Origen { get; set; }

    public string? Operador { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int? CosteServicio { get; set; }

    public string? InfoAdicional { get; set; }

    public string? CodigosEstado { get; set; }

    public decimal? Franquicia { get; set; }

    public decimal? FranquiciaMax { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public DateTime? FechaActivacion { get; set; }

    public DateTime? FechaVc { get; set; }

    public decimal? ImporteFianza { get; set; }

    public decimal? ImportePendiente { get; set; }

    public string? LimiteConsumo { get; set; }

    public string? SimDonante { get; set; }

    public string? SimActual { get; set; }

    public string? Pin { get; set; }

    public string? Puk { get; set; }

    public string? Restricciones { get; set; }

    public short? Datos { get; set; }

    public string? TarifaDatos { get; set; }

    public double? CosteDatos { get; set; }

    public short? Vodafonefijo { get; set; }

    public string? NumVf { get; set; }

    public short? Otros { get; set; }

    public string? OtrosServicios { get; set; }

    public string? Terminal { get; set; }

    public string? Imei { get; set; }

    public int? IdServidor { get; set; }

    public string? EstadoSincro { get; set; }

    public DateTime? FechaEstadoSincro { get; set; }

    public short? Nuevo { get; set; }

    public int? IdAdmin { get; set; }

    public decimal? CosteTerminal { get; set; }

    public decimal? CosteTerminalPvp { get; set; }

    public string? TerminalActual { get; set; }

    public string? ImeiTermActual { get; set; }

    public int? UploadTerminal { get; set; }

    public DateTime? FechaEntregaTerminal { get; set; }

    public int? UsuarioEntregaTerminal { get; set; }

    public short? TerminalPublicado { get; set; }

    public DateTime? FechaPublicacionTerminal { get; set; }

    public int? ImporteLimiteConsumo { get; set; }

    public string? Comentarios { get; set; }

    public int? OrdenDeLista { get; set; }

    public short? TerminalFinanciado { get; set; }

    public int? IdfinanTf { get; set; }

    public string? MotivoIncidencia { get; set; }

    public short? BloqReg { get; set; }

    public string? Fumr { get; set; }

    public int? BloqIdAdmin { get; set; }

    public int? IdDocumentoCt { get; set; }

    public string? AccionesPosActivacion { get; set; }

    public string? IdLineaAsociatel { get; set; }

    public int? IdLineaVinculada { get; set; }

    public string? NumContratoTrastienda { get; set; }

    public int? IdAutorizadoFibra { get; set; }

    public int? IdNumpc { get; set; }

    public int? IdCatpc { get; set; }

    public short? EsPcPrincipal { get; set; }

    public int IdLineaProlin { get; set; }

    public string? CuentaMaestraFibra { get; set; }
}
