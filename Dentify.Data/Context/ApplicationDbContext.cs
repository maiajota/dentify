using System.Reflection;
using Dentify.Core.Models;
using Dentify.Core.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Dentify.Data.Context;

public class ApplicationDbContext(AppSettings appSettings, ILogger<ApplicationDbContext> logWriter)
    : BaseDbContext(appSettings, logWriter, Assembly.GetExecutingAssembly())
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<UsuarioPaciente> UsuariosPacientes { get; set; }
    public DbSet<Convenio> Convenios { get; set; }
    public DbSet<Procedimento> Procedimentos { get; set; }
    public DbSet<ProcedimentoDente> ProcedimentosDentes { get; set; }
}
