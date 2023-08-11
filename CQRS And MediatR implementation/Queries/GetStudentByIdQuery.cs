using CQRS_And_MediatR_implementation.Models;
using MediatR;

namespace CQRS_And_MediatR_implementation.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
