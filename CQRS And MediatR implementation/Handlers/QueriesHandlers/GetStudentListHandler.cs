using CQRS_And_MediatR_implementation.Models;
using CQRS_And_MediatR_implementation.Queries;
using CQRS_And_MediatR_implementation.Repositories;
using MediatR;

namespace CQRS_And_MediatR_implementation.Handlers.QueriesHandlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentDetails>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDetails>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
           return await _studentRepository.GetStudentListAsync();
        }
    }
}
