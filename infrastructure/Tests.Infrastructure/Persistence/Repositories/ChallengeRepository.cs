using System.Xml.Linq;
using Tests.Application.Common.Interfaces.Repositories;
using Tests.Domain.Entities;

namespace Tests.Infrastructure.Persistence.Repositories
{
    public class ChallengeRepository : IChallengeRepository
    {
        private static List<Challenge> _challengeList = new List<Challenge>();

        public Challenge Add(Challenge challenge){
            _challengeList.Add(challenge);
            return challenge;
        }

        public Challenge? GetById(Guid Id){
            return _challengeList.Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(Challenge challenge)
        {
            _challengeList.Remove(challenge);
        }

        public Challenge Update(Challenge challenge)
        {
            var index = _challengeList.IndexOf(challenge);
            if(index >= 0){
                return _challengeList[index] = challenge;
            }
            return challenge;
        }

        public List<Challenge> GetList(string Name)
        {
            return _challengeList.
                Where(test => test.
            Name.ToLower().StartsWith((Name ?? "").ToLower())).ToList();
        }
    }
}