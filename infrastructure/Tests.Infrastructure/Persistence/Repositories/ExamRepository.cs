using Tests.Application.Common.Interfaces.Repositories;
using Tests.Domain.Entities;

namespace Tests.Infrastructure.Persistence.Repositories
{
    public class ExamRepository : IExamRepository
    {
        private static List<Exam> _examList = new List<Exam>();

        public Exam Add(Exam exam){
            _examList.Add(exam);
            return exam;
        }

        public Exam? GetById(Guid Id){
            return _examList.Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(Exam exam){
            _examList.Remove(exam);
        }

        public Exam Update(Exam exam){
            var index = _examList.IndexOf(exam);
            if(index >= 0){
                return _examList[index] = exam;
            }
            return exam;
        }

        public List<Exam> GetList(string Name)
        {
            return _examList.
                Where(test => test.
            Name.ToLower().StartsWith((Name ?? "").ToLower())).ToList();
        }
    }
}