using Tests.Domain.Entities;

namespace Tests.Application.Common.Interfaces.Services
{
    public interface IFinalExamService
    {
        FinalExam Add(FinalExam finalExam);

        FinalExam Update(FinalExam finalExam);

        void Remove(FinalExam finalExam);

        FinalExam? GetById(Guid Id);

        List<FinalExam> GetList(string Name);
    }
}