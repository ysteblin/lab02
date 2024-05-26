using Tests.Application.Common.Interfaces.Repositories;
using Tests.Application.Common.Interfaces.Services;
using Tests.Infrastructure.Persistence.Repositories;
using Tests.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Tests.Infrastructure
{
    public static class DependencyInjection
    {
         public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IExamService, ExamService>();

            services.AddScoped<IChallengeRepository, ChallengeRepository>();
            services.AddScoped<IChallengeService, ChallengeService>();

            services.AddScoped<IFinalExamRepository, FinalExamRepository>();
            services.AddScoped<IFinalExamService, FinalExamService>();
        
            return services;

        }

    }
}
