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
}
