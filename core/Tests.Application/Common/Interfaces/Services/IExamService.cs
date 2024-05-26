using Tests.Domain.Entities;

namespace Tests.Application.Common.Interfaces.Services
{
    public interface IExamService
    {
        Exam Add(Exam exam);

        Exam Update(Exam exam);

        void Remove(Exam exam);

        Exam? GetById(Guid Id);

        List<Exam> GetList(string Name);
    }
}