using MediatR;
using New_folder.Commands;
using New_folder.DataAccess;

namespace New_folder.Handlers;

public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand>
{
    private readonly IDataAccess _data;
    
    public DeletePersonCommandHandler(IDataAccess dataAccess) => _data = dataAccess;

    public Task<Unit> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_data.DeletePerson(request.id));
    }
}