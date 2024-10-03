using CrudWithEfCore.Entities;

namespace CrudWithEfCore.Services;

public interface IPersonService
{
    Task<IEnumerable<Person>> GetPersonAsync();
    
    Task<Person?> GetPersonByIdAsync(int id);
    
    Task<bool> CreatePersonAsync(Person person);
    
    Task<bool> UpdatePersonAsync(Person person);
    
    Task<bool> DeletePersonAsync(int id);
}