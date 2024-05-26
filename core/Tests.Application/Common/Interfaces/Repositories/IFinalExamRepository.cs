using Tests.Domain.Entities;

namespace Tests.Application.Common.Interfaces.Repositories
{
    public interface IFinalExamRepository
    {
        FinalExam Add(FinalExam finalExam);

        FinalExam Update(FinalExam finalExam);

        void Remove(FinalExam finalExam);

        FinalExam? GetById(Guid Id);

        List<FinalExam> GetList(string Name);
    }
}