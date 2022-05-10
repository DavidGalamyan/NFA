using Microsoft.EntityFrameworkCore;
using NFA.Domain.Entity;

namespace NFA.Appplication.Interfaces
{
	/// <summary>
	/// Контекст БД
	/// </summary>
	public interface INfaDbContext
	{
		DbSet<Site> Sites { get; set; }
		DbSet<Content> Contents { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
