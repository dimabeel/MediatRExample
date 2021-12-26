using MediatR;
using Microsoft.AspNetCore.Mvc;
using New_folder.Queries;
using New_folder.Commands;
using New_folder.Models;

namespace New_folder.Controllers;

[ApiController]

[Route("person")]
public class PersonController : ControllerBase
{
    private readonly IMediator _mediator;

    public PersonController(IMediator mediator)
        => _mediator = mediator;

    [HttpGet]
    public async Task<ActionResult<List<PersonModel>>> GetAll()
    {
        return await _mediator.Send(new GetPersonsQuery());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PersonModel>> GetById(int id)
    {
        return await _mediator.Send(new GetPersonByIdQuery(id));
    }

    [HttpPost]
    public async Task<ActionResult<PersonModel>> CreateNew(string firstName, string lastName)
    {
        return await _mediator.Send(new CreatePersonCommand(firstName, lastName));
    }

    [HttpPut]
    public async Task<ActionResult<PersonModel>> Update(PersonModel person)
    {
        return await _mediator.Send(new UpdatePersonCommand(person));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Unit>> Delete(int id)
    {
        return await _mediator.Send(new DeletePersonCommand(id));
    }
}