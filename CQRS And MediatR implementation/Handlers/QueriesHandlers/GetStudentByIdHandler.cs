using CQRS_And_MediatR_implementation.Models;
using CQRS_And_MediatR_implementation.Queries;
using CQRS_And_MediatR_implementation.Repositories;
using MediatR;

namespace CQRS_And_MediatR_implementation.Handlers.QueriesHandlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, StudentDetails>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByIdHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDetails> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentByIdAsync(request.Id);
        }
    }
}
