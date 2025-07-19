namespace Dentify.Core.Models;

public class Paciente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string? Cep { get; set; }
    public string? Logradouro { get; set; }
    public string? Bairro { get; set; }
    public string? Numero { get; set; }
    public string Telefone { get; set; }

    public IEnumerable<UsuarioPaciente> UsuariosPacientes { get; set; }
    public IEnumerable<Procedimento> Procedimentos { get; set; }
}
