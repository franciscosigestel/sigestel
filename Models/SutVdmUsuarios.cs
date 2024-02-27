using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutVdmUsuarios
{
    public int Id { get; set; }

    public string IdClienteVdm { get; set; } = null!;

    public int IdClienteInterno { get; set; }

    public string NombreCliente { get; set; } = null!;

    public string Aplicacion { get; set; } = null!;

    public string? Cif { get; set; }

    public string? IdCuenta { get; set; }
}
