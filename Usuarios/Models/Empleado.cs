using System;
using System.Collections.Generic;

namespace Usuarios.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Departamento { get; set; }

    public string? Cargo { get; set; }

    public DateTime? FechaContratacion { get; set; }

    public decimal? Salario { get; set; }
}
