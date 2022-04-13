using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {   
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "e0ef63a3-d590-4849-a1f3-dcd55520c29d",
                    RoleId = "32b63cee-482f-460c-89a1-26aafba2d333"
                },
                new IdentityUserRole<string>
                {
                    UserId = "b71d9170-e714-473c-9a7f-9742e8c383f5",
                    RoleId = "62b63cee-482f-460c-89a1-26aafba2d336"
                });
        }
    }
}