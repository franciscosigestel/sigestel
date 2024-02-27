using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TmpVdfResumenFacturacionCompleta
{
    public int? Idempresa { get; set; }

    public string? NifCif { get; set; }

    public string? Fechainicio { get; set; }

    public string? Fechafin { get; set; }

    public string? Ciclo { get; set; }

    public string? Telef { get; set; }

    public int? Idlinea { get; set; }

    public decimal? Impcuota { get; set; }

    public decimal? Descuota { get; set; }

    public decimal? Impconsumo { get; set; }

    public decimal? Desconsumo { get; set; }

    public decimal? Total { get; set; }

    public int? Idusuariolin { get; set; }

    public string? Estado { get; set; }

    public DateTime? Fechaalta { get; set; }

    public DateTime? Fechabaja { get; set; }

    public string? Tipolinea { get; set; }

    public string? Extnumtelefono { get; set; }

    public string? Telef3 { get; set; }

    public int? UsuIdusuario { get; set; }

    public string? UsuNombre { get; set; }

    public string? UsuApellidos { get; set; }

    public string? UsuNif { get; set; }

    public int? UsuIdcliente { get; set; }

    public DateTime? UsuFechabaja { get; set; }

    public string? UsuEstado { get; set; }

    public int? UsuRecibirfacturaemail { get; set; }

    public int? UsuRecibirfacturacorreopostal { get; set; }

    public int? UsuExentofacturacion { get; set; }

    public string? UsuNombrebanco { get; set; }

    public string? UsuNumcuenta { get; set; }

    public string? UsuPerfilusuario { get; set; }

    public int? UsuAsociacionperfilusuario { get; set; }

    public string? DirNombre { get; set; }

    public string? DirDireccion { get; set; }

    public string? DirCodpostal { get; set; }

    public string? DirPoblacion { get; set; }

    public string? DirProvincia { get; set; }
}
