using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class Empresas
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Cif { get; set; }

    public string? Direccion { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaModif { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public int? CodigoOperador { get; set; }

    /// <summary>
    /// Serie General
    /// </summary>
    public string? Serie { get; set; }

    /// <summary>
    /// Contador Serie General
    /// </summary>
    public string? Num { get; set; }

    /// <summary>
    /// Contador Informativas
    /// </summary>
    public string? Num2 { get; set; }

    public string? NombreBanco { get; set; }

    public string? NumCuenta { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public int? CosteServicio { get; set; }

    public decimal? Franquicia { get; set; }

    public decimal? FranquiciaMax { get; set; }

    public int? CabeceraColectivo { get; set; }

    public int? IdAsesor { get; set; }

    public string? TelefonoAsesor { get; set; }

    public decimal? MargenColectivo { get; set; }

    public string? SufijoNorma19 { get; set; }

    public int? IdAgente { get; set; }

    public DateTime? FechaDesdeAgente { get; set; }

    public DateTime? FechaHastaAgente { get; set; }

    public string? CuentaIva { get; set; }

    public string? CuentaBase { get; set; }

    public int? AutogestionProlin { get; set; }

    public int? AutogestionServicios { get; set; }

    public int? AutogestionTerminales { get; set; }

    public int? AutogestionIncidencias { get; set; }

    public int? AutogestionSms { get; set; }

    public int? IdGrupo { get; set; }

    public int? IdCatalogo { get; set; }

    public decimal? PorcentajeDescuentoColectivo { get; set; }

    public string? MargenTerminal { get; set; }

    public int? FranquiciaVoz { get; set; }

    public string? NombreAdminLegal { get; set; }

    public string? DniAdminLegal { get; set; }

    public string? RefOrdenDomiciliacion { get; set; }

    public DateTime? FechaOrdenDomiciliacion { get; set; }

    public string? NombreComercial { get; set; }

    public string? PlanPrecios { get; set; }

    public int? IdcVinculada { get; set; }

    public string? EmailFacturacion { get; set; }

    public decimal? PorcentajeDtoCatalogoOp { get; set; }

    /// <summary>
    /// Serie Abonos
    /// </summary>
    public string? Serie3 { get; set; }

    /// <summary>
    /// Contador Serie Abonos
    /// </summary>
    public int? Num3 { get; set; }

    /// <summary>
    /// Serie Revendedor
    /// </summary>
    public string? SerieR { get; set; }

    public int? NumR { get; set; }

    public string? FormaPago { get; set; }

    public virtual ICollection<SutAdministradores> SutAdministradores { get; set; } = new List<SutAdministradores>();

    public virtual ICollection<SutClientesUsuariosFacturas> SutClientesUsuariosFacturas { get; set; } = new List<SutClientesUsuariosFacturas>();

    public virtual ICollection<SutDireccionesClientes> SutDireccionesClientes { get; set; } = new List<SutDireccionesClientes>();

    public virtual ICollection<SutLineas> SutLineas { get; set; } = new List<SutLineas>();

    public virtual ICollection<SutPeticionesIncidencias> SutPeticionesIncidencias { get; set; } = new List<SutPeticionesIncidencias>();

    public virtual ICollection<SutUsuarios> SutUsuarios { get; set; } = new List<SutUsuarios>();
}
