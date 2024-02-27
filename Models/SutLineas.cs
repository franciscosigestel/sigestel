using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutLineas
{
    public int IdLinea { get; set; }

    public string NumTelefono { get; set; } = null!;

    public int IdUsuarioLin { get; set; }

    public string Origen { get; set; } = null!;

    public string? Operador { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? NumTelefono2 { get; set; }

    public string? InfoAdicional { get; set; }

    public int? CosteServicio { get; set; }

    public decimal? Franquicia { get; set; }

    public decimal? FranquiciaMax { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public decimal? ImporteFianza { get; set; }

    public decimal? LimiteConsumo { get; set; }

    public decimal? ImportePendiente { get; set; }

    public int IdCliente { get; set; }

    public decimal? MargenColectivo { get; set; }

    public string? Alias { get; set; }

    public int? IdLineaVinculada { get; set; }

    public string? MotivoBaja { get; set; }

    public string? TipoLinea { get; set; }

    public string? IdLineaAsociatel { get; set; }

    public string? NumContratoTrastienda { get; set; }

    public int? IdAutorizadoFibra { get; set; }

    public string? ExtNumTelefono { get; set; }

    public int? IdNumpc { get; set; }

    public int? IdCatpc { get; set; }

    public short? EsPcPrincipal { get; set; }

    public short? BloqueoLinea { get; set; }

    public string? ComentarioBloqueo { get; set; }

    public string? CuentaMaestraFibra { get; set; }

    public virtual Empresas IdClienteNavigation { get; set; } = null!;

    public virtual SutUsuarios IdUsuarioLinNavigation { get; set; } = null!;

    public virtual ICollection<SutCompromisos> SutCompromisos { get; set; } = new List<SutCompromisos>();

    public virtual ICollection<SutFichAdjuntos> SutFichAdjuntos { get; set; } = new List<SutFichAdjuntos>();

    public virtual ICollection<SutPeticionesIncidencias> SutPeticionesIncidencias { get; set; } = new List<SutPeticionesIncidencias>();

    public virtual ICollection<SutServicios> SutServicios { get; set; } = new List<SutServicios>();

    public virtual ICollection<SutSims> SutSims { get; set; } = new List<SutSims>();

    public virtual ICollection<SutTerminales> SutTerminales { get; set; } = new List<SutTerminales>();
}
