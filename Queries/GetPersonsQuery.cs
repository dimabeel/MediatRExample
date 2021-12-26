using MediatR;
using New_folder.Models;

namespace New_folder.Queries;

public record GetPersonsQuery() : IRequest<List<PersonModel>>;