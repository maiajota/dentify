namespace Dentify.Core.Models;

public class Procedimento
{
    public int Id { get; set; }
    public int PacienteId { get; set; }
    public int ConvenioId { get; set; }
    public DateOnly DataInicio { get; set; }
    public string Descricao { get; set; }

    public Paciente Paciente { get; set; }
    public Convenio Convenio { get; set; }

    public IEnumerable<ProcedimentoDente> ProcedimentoDente { get; set; }
}
