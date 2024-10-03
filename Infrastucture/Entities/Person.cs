using System.ComponentModel.DataAnnotations;

namespace CrudWithEfCore.Entities;

public class Person
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Gender { get; set; } = null!;

}