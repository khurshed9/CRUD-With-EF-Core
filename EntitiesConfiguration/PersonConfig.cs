using CrudWithEfCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudWithEfCore.EntitiesConfiguration;

public class PersonConfig : IEntityTypeConfiguration<Person>
{ 
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("People");
        builder.HasKey(i => i.Id).HasName("personsPrimaryKey");
        builder.Property(i => i.Id).HasColumnName("id");
        builder.Property(n => n.Name).HasColumnName("name");
        builder.Property(a => a.Age).HasColumnName("age");
        builder.Property(g => g.Gender).HasColumnName("gender");

        builder.ToTable(x => x.HasCheckConstraint("ageConstraint", "age > 10 and age < 60"));
        builder.Property(g => g.Gender).HasMaxLength(6);
        
        builder.HasData(
            new Person { Id = 20, Name = "John Doe", Age = 30, Gender = "Male" },
            new Person { Id = 21, Name = "Jane Doe", Age = 25, Gender = "Female" },
            new Person { Id = 22, Name = "Mike Doe", Age = 35, Gender = "Male" }
        );
    }
}