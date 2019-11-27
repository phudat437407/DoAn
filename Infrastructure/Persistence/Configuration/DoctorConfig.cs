using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Persistence.Configuration
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor> {
    public void Configure(EntityTypeBuilder<Doctor> builder) {
        builder.ToTable("Doctor");

        builder.HasKey(i => i.Id);

        builder.Property(i => i.Name)
            .HasMaxLength(40)
            .IsRequired(true);

        builder.Property(i => i.BirthDate)
            .IsRequired(true);

        builder.Property(i => i.Phone)
            .HasMaxLength(10)
            .IsRequired(true);
        }
    }
}