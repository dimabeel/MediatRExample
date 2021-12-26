using MediatR;
using New_folder.Commands;
using New_folder.DataAccess;
using New_folder.Models;

namespace New_folder.Handlers;

public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand, PersonModel>
{
    private readonly IDataAccess _data;
    
    public UpdatePersonCommandHandler(IDataAccess dataAccess) => _data = dataAccess;

    public Task<PersonModel> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_data.UpdatePerson(request.person));
    }
}