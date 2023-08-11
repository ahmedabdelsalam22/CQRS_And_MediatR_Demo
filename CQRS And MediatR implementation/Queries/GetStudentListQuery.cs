using CQRS_And_MediatR_implementation.Models;
using MediatR;

namespace CQRS_And_MediatR_implementation.Queries
{
    public class GetStudentListQuery : IRequest<List<StudentDetails>>
    {
    }
}
