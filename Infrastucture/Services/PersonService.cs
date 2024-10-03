using CrudWithEfCore.DataContext;
using CrudWithEfCore.Entities;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace CrudWithEfCore.Services;

public class PersonService : IPersonService
{
    private readonly ApplicationDbContext _context;

    public PersonService(ApplicationDbContext applicationDbContext)
    {
        _context = applicationDbContext;
    }
    
    public async Task<IEnumerable<Person>> GetPersonAsync()
    {
        try
        {
            return await _context.Persons.ToListAsync();
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<Person?> GetPersonByIdAsync(int id)
    {
        try
        {
            return await _context.Persons.FindAsync(id);
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<bool> CreatePersonAsync(Person person)
    {
        try
        {
            if (person == null) return false;
            await _context.Persons.AddAsync(person);
            int res = await _context.SaveChangesAsync();
            return res != 0;
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<bool> UpdatePersonAsync(Person person)
    {
        try
        {
            Person? userById = await _context.Persons.FindAsync(person.Id);
            if (userById == null) return false;
            userById.Name = person.Name;
            userById.Age = person.Age;
            userById.Gender = person.Gender;
            int res = await _context.SaveChangesAsync();
            return res!= 0;
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<bool> DeletePersonAsync(int id)
    {
        try
        {
            Person? person = await _context.Persons.FindAsync(id);
            if (person == null) return false;

            _context.Persons.Remove(person);
            int res = await _context.SaveChangesAsync();
            return res != 0;
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}