using MediatR;

namespace New_folder.Commands;

public record DeletePersonCommand(int id) : IRequest;