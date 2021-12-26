using MediatR;
using New_folder.Models;

namespace New_folder.Queries;

public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;