using MediatR;
using New_folder.Models;

namespace New_folder.Commands;

public record UpdatePersonCommand(PersonModel person) : IRequest<PersonModel>;