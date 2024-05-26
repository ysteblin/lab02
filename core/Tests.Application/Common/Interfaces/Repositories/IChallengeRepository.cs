using Tests.Domain.Entities;

namespace Tests.Application.Common.Interfaces.Repositories
{
    public interface IChallengeRepository
    {
        Challenge Add(Challenge challenge);

        Challenge Update(Challenge challenge);

        void Remove(Challenge challenge);

        Challenge? GetById(Guid Id);

        List<Challenge> GetList(string Name);
    }
}