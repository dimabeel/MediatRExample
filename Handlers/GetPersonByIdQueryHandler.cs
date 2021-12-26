using MediatR;
using New_folder.Queries;
using New_folder.DataAccess;
using New_folder.Models;

namespace New_folder.Handlers;

public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
{
    private readonly IDataAccess _data;
    
    public GetPersonByIdQueryHandler(IDataAccess dataAccess) => _data = dataAccess;

    public Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_data.GetPerson(request.Id));
    }
}