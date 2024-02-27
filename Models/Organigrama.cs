using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class Organigrama
{
    public string IdEmpleado { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Nif { get; set; }

    public string? UnidadNegocio { get; set; }

    public string? IdDepartamento { get; set; }

    public string? DescDepartamento { get; set; }

    public string? IdCargo { get; set; }

    public string? DescCargo { get; set; }

    public string? IdPosicion { get; set; }

    public string? DescPosicion { get; set; }

    public string? UsuarioRed { get; set; }

    public string? Email { get; set; }

    public string? FfinContrato { get; set; }

    public string? Calle { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public string? Ubicacion { get; set; }

    public bool? Act { get; set; }

    public int? IdGrupo { get; set; }

    public string? Password { get; set; }

    public string? BusinessUnit { get; set; }

    public string? Deptid { get; set; }

    public string? EmplidDelegate { get; set; }
}
