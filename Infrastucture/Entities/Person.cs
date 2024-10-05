using System.ComponentModel.DataAnnotations;

namespace CrudWithEfCore.Entities;

public class Person
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int Age { get; set; }

    [Required]
    public string Gender { get; set; }

}