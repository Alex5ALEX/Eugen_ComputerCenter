using ComputerCenterServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerCenterServer.Configuration;

public class InitDBPerson : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {


        builder.HasData(new Person
        {
            Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
            Name = "Admin",
            Surname = "Admin",
            Phone = string.Empty,
            Email = string.Empty,
            Address = string.Empty,
            Login = "admin",
            Password = "admin"
        });

    }

}



public class InitDBAdmin : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {


        builder.HasData(new Admin
        {
            Id = Guid.NewGuid(),
            Jobtitle = "Admin",
            Id_Person = Guid.Parse("00000000-0000-0000-0000-000000000001")
        });


    }

}
