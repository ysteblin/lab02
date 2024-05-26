using Tests.Domain.Entities;
using Tests.Application.Common.Interfaces.Repositories;
using Tests.Application.Common.Interfaces.Services;
using System.Collections.Generic;

namespace Tests.Infrastructure.Services
{
    public class ChallengeService : IChallengeService

    {
        private readonly IChallengeRepository _challengeRepository;

        public ChallengeService(IChallengeRepository challengeRepository){
            _challengeRepository = challengeRepository;
        }


        public Challenge Add(Challenge challenge){
            if (challenge.PassingScore < 0)
            {
                throw new Exception("Проходной балл не может иметь отрицательное значение");
            }

            return _challengeRepository.Add(challenge);
        }

        public Challenge? GetById(Guid Id){
            return _challengeRepository.GetById(Id);
        }

        public void Remove(Challenge challenge){
            _challengeRepository.Remove(challenge);
        }

        public Challenge Update(Challenge challenge){
            return _challengeRepository.Update(challenge);
        }

        public List<Challenge> GetList(string Name)
        {
            return _challengeRepository.GetList(Name);
        }
    }
}