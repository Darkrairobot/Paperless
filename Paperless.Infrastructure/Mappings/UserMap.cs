using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Paperless.Domain.Entities;
using Paperless.Infrastructure.Identity;

namespace Paperless.Infrastructure.Mappings;

public class UserMap : IEntityTypeConfiguration<ApplicationUser>
{

    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.Name).HasColumnType("varchar(50)").IsRequired();
    }
    
}