using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutClientesUsuariosFacturas
{
    public int IdClienteFac { get; set; }

    public int? IdUsuarioFac { get; set; }

    public int IdFactura { get; set; }

    public string? NumFactura { get; set; }

    public int? IdProceso { get; set; }

    public virtual Empresas IdClienteFacNavigation { get; set; } = null!;

    public virtual SutFacturas IdFacturaNavigation { get; set; } = null!;
}
