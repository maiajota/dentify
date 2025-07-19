namespace Dentify.Core.Models;

public class ProcedimentoDente
{
    public int Id { get; set; }
    public int ProcedimentoId { get; set; }
    public int DenteNumero { get; set; }

    public Procedimento Procedimento { get; set; }
}
