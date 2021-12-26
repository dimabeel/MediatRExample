using MediatR;
using New_folder.Queries;
using New_folder.DataAccess;
using New_folder.Models;

namespace New_folder.Handlers;

public class GetPersonsQueryHandler : IRequestHandler<GetPersonsQuery, List<PersonModel>>
{
    private readonly IDataAccess _data;
    
    public GetPersonsQueryHandler(IDataAccess dataAccess) => _data = dataAccess;

    public Task<List<PersonModel>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_data.Get());
    }
}