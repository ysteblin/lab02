using Tests.Domain.Entities;
using Tests.Application.Common.Interfaces.Repositories;
using Tests.Application.Common.Interfaces.Services;
using Tests.Infrastructure.Persistence.Repositories;

namespace Tests.Infrastructure.Services
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;

        public ExamService(IExamRepository examRepository){
            _examRepository = examRepository;
        }


        public Exam Add(Exam exam){
            if(exam.TestTime < 0){
                throw new Exception("Время теста не может иметь отрицательное значение");
            }

            if(exam.PassingScore < 0) 
            {
                throw new Exception("Проходной балл не может иметь отрицательное значение");
            }

            if (exam.DifficultyLevel < 0)
            {
                throw new Exception("Уровень сложности не может иметь отрицательное значение");
            }

            if (exam.QuestionsCount < 0)
            {
                throw new Exception("Количество вопросов не может иметь отрицательное значение");
            }

            return _examRepository.Add(exam);
        }

        public Exam? GetById(Guid Id){
            return _examRepository.GetById(Id);
        }

        public void Remove(Exam exam){
            _examRepository.Remove(exam);
        }

        public Exam Update(Exam exam){
            return _examRepository.Update(exam);
        }

        public List<Exam> GetList(string Name)
        {
            return _examRepository.GetList(Name);
        }
    }
}