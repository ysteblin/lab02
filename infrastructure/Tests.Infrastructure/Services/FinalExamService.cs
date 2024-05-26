using Tests.Domain.Entities;
using Tests.Application.Common.Interfaces.Repositories;
using Tests.Application.Common.Interfaces.Services;
using Tests.Infrastructure.Persistence.Repositories;

namespace Tests.Infrastructure.Services
{
    public class FinalExamService : IFinalExamService
    {
        private readonly IFinalExamRepository _finalExamRepository;

        public FinalExamService(IFinalExamRepository finalExamRepository)
        {
            _finalExamRepository = finalExamRepository;
        }


        public FinalExam Add(FinalExam finalExam)
        {
            if (finalExam.TestTime < 0)
            {
                throw new Exception("Время теста не может иметь отрицательное значение");
            }

            if (finalExam.PassingScore < 0)
            {
                throw new Exception("Проходной балл не может иметь отрицательное значение");
            }

            return _finalExamRepository.Add(finalExam);
        }

        public FinalExam? GetById(Guid Id){
            return _finalExamRepository.GetById(Id);
        }

        public void Remove(FinalExam finalExam)
        {
            _finalExamRepository.Remove(finalExam);
        }

        public FinalExam Update(FinalExam finalExam)
        {
            return _finalExamRepository.Update(finalExam);
        }

        public List<FinalExam> GetList(string Name)
        {
            return _finalExamRepository.GetList(Name);
        }
    }
}