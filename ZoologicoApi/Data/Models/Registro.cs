//VariablesRegistro

namespace ZoologicoApi.Data.Models;

public partial class Registro
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Contraseña { get; set; }

    public string? Contrasena { get; set; }

    public string Discriminator { get; set; } = null!;

    public string? NombreUsuario { get; set; }
}
