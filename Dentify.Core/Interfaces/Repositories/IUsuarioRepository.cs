using Dentify.Core.Interfaces.Repositories.Base;
using Dentify.Core.Models;

namespace Dentify.Core.Interfaces.Repositories;

public interface IUsuarioRepository
{
    public Task AdicionarAsync(Usuario usuario);
    public Task BuscarAsync();
    public Task AtualizarAsync();
    public Task DeletarAsync();
}
