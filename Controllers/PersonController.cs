using CrudWithEfCore.DataContext;
using CrudWithEfCore.Entities;
using CrudWithEfCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudWithEfCore.Controllers;

[Route("/api/persons")]
[ApiController]

public class PersonController(IPersonService _personService) : ControllerBase
{

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IResult> GetPersons()
    {
        return Results.Ok(await _personService.GetPersonAsync());
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IResult> GetPersonById(int id)
    {
        if (id == 0) return Results.BadRequest();
        return Results.Ok(await _personService.GetPersonByIdAsync(id));
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IResult> CreatePerson( [FromBody]Person person)
    {
        if (person == null) return Results.BadRequest("Person object is null.");
        var res = await _personService.CreatePersonAsync(person);
        //if (res == true)
        //{
        //    return Results.Ok();
        //}
        //else
        //{
        //    return Results.BadRequest();
        //}
        return res? Results.Ok("Person created successfully.") : Results.BadRequest("Failed to create person.");
    }
    
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IResult> UpdatePerson(Person person)
    {
        if (person == null) return Results.NotFound();
        return Results.Ok(await _personService.UpdatePersonAsync(person));
    }
    
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IResult> DeletePerson(int id)
    {
        if (id == 0) return Results.BadRequest();
        return Results.Ok(await _personService.DeletePersonAsync(id));
    }
}