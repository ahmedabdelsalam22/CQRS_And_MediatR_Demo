using MediatR;

namespace CQRS_And_MediatR_implementation.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
