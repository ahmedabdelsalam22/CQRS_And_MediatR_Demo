using CQRS_And_MediatR_implementation.Commands;
using CQRS_And_MediatR_implementation.Models;
using CQRS_And_MediatR_implementation.Repositories;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRS_And_MediatR_implementation.Handlers.CommandsHandlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, StudentDetails>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDetails> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var studentDetails = new StudentDetails() 
            {
                StudentName = request.StudentName,
                StudentEmail = request.StudentEmail,
                StudentAddress = request.StudentAddress,
                StudentAge = request.StudentAge
            };

            return await _studentRepository.AddStudentAsync(studentDetails);
        }
    }
}
