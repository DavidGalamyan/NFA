using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFA.Domain.Entity;

namespace NFA.Persistence.EntityTypeConfigurations
{
	public class ContentConfiguration : IEntityTypeConfiguration<Content>
	{
		public void Configure(EntityTypeBuilder<Content> builder)
		{
			builder.HasKey(x => x.Id);
		}
	}
}
