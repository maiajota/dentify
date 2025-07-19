namespace Dentify.Core.Models;

public class UsuarioPaciente
{
    public int IdUsuario { get; set; }
    public int IdPaciente { get; set; }

    public Usuario Usuario { get; set; }
    public Paciente Paciente { get; set; }
}
