using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutDireccionesClientes
{
    public int IdDireccion { get; set; }

    public int? IdCliente { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string CodPostal { get; set; } = null!;

    public string Poblacion { get; set; } = null!;

    public string Provincia { get; set; } = null!;

    public int Predeterminado { get; set; }

    public virtual Empresas? IdClienteNavigation { get; set; }
}
