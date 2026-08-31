using DotNetLearning.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetLearning.Database.Mappings;

public class BlogMap : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.ToTable("Blog");
        builder.HasKey(pk => pk.Id);
        builder.Property(p => p.Name);
        builder.Property(p => p.SiteUri);
        builder.HasMany(m => m.Posts)
            .WithOne(o => o.Blog)
            .HasForeignKey(fk => fk.BlogId)
            .HasPrincipalKey(pk => pk.Id);
    }
}