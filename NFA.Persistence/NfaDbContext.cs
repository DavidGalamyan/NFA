using Microsoft.EntityFrameworkCore;
using NFA.Appplication.Interfaces;
using NFA.Domain.Entity;
using NFA.Persistence.EntityTypeConfigurations;

namespace NFA.Persistence
{
	public class NfaDbContext : DbContext, INfaDbContext
	{
		public DbSet<Site> Sites { get; set ; }

		public DbSet<Content> Contents { get; set; }

		public NfaDbContext(DbContextOptions<NfaDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new SiteConfiguration());
			builder.ApplyConfiguration(new ContentConfiguration());
			base.OnModelCreating(builder);
		}

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
		{
			foreach (var entry in ChangeTracker.Entries<BaseEntity>())
			{
				var utcNow = DateTime.UtcNow;

				switch (entry.State)
				{
					case EntityState.Added:
						entry.Entity.Id = new Guid(utcNow.ToString());
						entry.Entity.TimeOfCreation = utcNow;
						entry.Entity.TimeOfUpdate = utcNow;
						break;
					case EntityState.Modified:
						entry.Entity.TimeOfUpdate = utcNow;
						break;
				}
			}
			return base.SaveChangesAsync(cancellationToken);
		}
	}
}
