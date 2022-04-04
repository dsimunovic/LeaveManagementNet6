using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "e0ef63a3-d590-4849-a1f3-dcd55520c29d",
                    Email = "dorotea.simunovic@hotmail.com",
                    NormalizedEmail = "DOROTEA.SIMUNOVIC@HOTMAIL.COM",
                    NormalizedUserName = "DOROTEA.SIMUNOVIC@HOTMAIL.COM",
                    UserName = "dorotea.simunovic@hotmail.com",
                    FirstName = "Dorotea",
                    LastName = "Simunovic",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "b71d9170-e714-473c-9a7f-9742e8c383f5",
                    Email = "email@email.com",
                    NormalizedEmail = "EMAIL@EMAIL.COM",
                    NormalizedUserName = "EMAIL@EMAIL.COM",
                    UserName = "email@email.com",
                    FirstName = "Obican",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                });
        }
    }
}