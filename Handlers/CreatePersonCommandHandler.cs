using MediatR;
using New_folder.Commands;
using New_folder.DataAccess;
using New_folder.Models;

namespace New_folder.Handlers;

public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, PersonModel>
{
    private readonly IDataAccess _data;
    
    public CreatePersonCommandHandler(IDataAccess dataAccess) => _data = dataAccess;

    public Task<PersonModel> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
    }
}