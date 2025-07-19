using Dentify.Core.Interfaces.Repositories;
using Dentify.Core.Models;
using Dentify.Data.Context;
using Dentify.Data.Repositories.Base;

namespace Dentify.Data.Repositories;

public class UsuarioRepository(ApplicationDbContext dbContext) : BaseRepository(dbContext), IUsuarioRepository
{
    private readonly ApplicationDbContext _dbcontext = dbContext;

    public async Task AdicionarAsync(Usuario usuario)
    {
        await _dbcontext.Usuarios.AddAsync(usuario);
        await _dbcontext.SaveChangesAsync();
    }

    public async Task BuscarAsync()
    {
        return;
    }

    public async Task AtualizarAsync()
    {
        return;
    }

    public async Task DeletarAsync()
    {
    return;
    }
}
