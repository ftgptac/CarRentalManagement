using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    Name = "BMW",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "system",
                    UpdatedBy = "system"
                },
                new Make
                {
                    Id = 2,
                    Name = "Toyota",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "system",
                    UpdatedBy = "system"
                }
            );
        }
    }
}
