using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFA.Domain.Entity;

namespace NFA.Persistence.EntityTypeConfigurations
{
	public class SiteConfiguration : IEntityTypeConfiguration<Site>
	{
		public void Configure(EntityTypeBuilder<Site> builder)
		{
			builder.HasKey(x => x.Id);
		}
	}
}
