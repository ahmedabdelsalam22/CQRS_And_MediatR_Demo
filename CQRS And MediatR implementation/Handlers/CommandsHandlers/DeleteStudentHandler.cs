using CQRS_And_MediatR_implementation.Commands;
using CQRS_And_MediatR_implementation.Repositories;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRS_And_MediatR_implementation.Handlers.CommandsHandlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<int> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var studentDetails = await _studentRepository.GetStudentByIdAsync(request.Id);
            if (studentDetails == null)
                return default;

            return await _studentRepository.DeleteStudentAsync(request.Id);
        }
    }
}
