using MediatR;
using New_folder.Models;

namespace New_folder.Commands;

public record CreatePersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;