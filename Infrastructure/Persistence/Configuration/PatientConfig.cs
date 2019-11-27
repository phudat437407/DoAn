using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;

namespace Infrastructure.Persistence.Configuration
{
    public class PatientConfig : IEntityTypeConfiguration<Patient> {
    public void Configure(EntityTypeBuilder<Patient> builder) {
        builder.ToTable("Patient");

        builder.HasKey(i => i.Id);

        builder.Property(i => i.Name)
            .HasMaxLength(40)
            .IsRequired(true);

        builder.Property(i => i.Gender)
            .HasMaxLength(84)
            .IsRequired(true);

        builder.Property(i => i.BirthDate)
            .IsRequired(true);

        builder.Property(i => i.Phone)
            .HasMaxLength(10)
            .IsRequired(true);
    }
}
}