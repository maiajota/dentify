namespace Dentify.Core.Models;

public class Convenio
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public IEnumerable<Procedimento> Procedimentos { get; set; }
}
