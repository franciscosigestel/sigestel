using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutTokensEmails
{
    public int Idregistro { get; set; }

    public int Idcolectivo { get; set; }

    public string? Nifusuario { get; set; }

    public int? Idusuario { get; set; }

    public string Token { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public int? Idadministrador { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaHoraConfirmacion { get; set; }

    public string? IpConfirmacion { get; set; }

    public string? DatosNavegadorConfirmacion { get; set; }
}
