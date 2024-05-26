using Tests.Application.Common.Interfaces.Repositories;
using Tests.Domain.Entities;

namespace Tests.Infrastructure.Persistence.Repositories
{
    public class FinalExamRepository : IFinalExamRepository
    {
        private static List<FinalExam> _finalExamList = new List<FinalExam>();

        public FinalExam Add(FinalExam finalExam){
            _finalExamList.Add(finalExam);
            return finalExam;
        }

        public FinalExam? GetById(Guid Id){
            return _finalExamList.Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(FinalExam finalExam){
            _finalExamList.Remove(finalExam);
        }

        public FinalExam Update(FinalExam finalExam){
            var index = _finalExamList.IndexOf(finalExam);
            if(index >= 0){
                return _finalExamList[index] = finalExam;
            }
            return finalExam;
        }

        public List<FinalExam> GetList(string Name)
        {
            return _finalExamList.
                Where(test => test.
            Name.ToLower().StartsWith((Name ?? "").ToLower())).ToList();
        }
    }
}