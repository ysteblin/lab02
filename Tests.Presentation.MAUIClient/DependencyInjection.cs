using Tests.Infrastructure;
using Tests.Presentation.MAUIClient.Pages;
using Tests.Presentation.MAUIClient.ViewModels;

namespace Tests.Presentation.MAUIClient
{
    public static class DependencyInjection
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddInfrastructure();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<ViewModels.MainPageViewModel>();

            mauiAppBuilder.Services.AddSingleton<ViewModels.Tests.Challenge.ChallengeTestViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Tests.Exam.ExamTestViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Tests.FinalExam.FinalExamTestViewModel>();

            mauiAppBuilder.Services.AddSingleton<ViewModels.Tests.Challenge.AddChallengeTestViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Tests.Exam.AddExamTestViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Tests.FinalExam.AddFinalExamTestViewModel>();

            mauiAppBuilder.Services.AddSingleton<ViewModels.Tests.Challenge.GetChallengeTestViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Tests.Exam.GetExamTestViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Tests.FinalExam.GetFinalExamTestViewModel>();

            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
        {

            mauiAppBuilder.Services.AddSingleton<Pages.MainPage>();

            mauiAppBuilder.Services.AddSingleton<Pages.Tests.Challenge.ChallengeTestPage>();
            mauiAppBuilder.Services.AddSingleton<Pages.Tests.Exam.ExamTestPage>();
            mauiAppBuilder.Services.AddSingleton<Pages.Tests.FinalExam.FinalExamTestPage>();

            mauiAppBuilder.Services.AddSingleton<Pages.Tests.Challenge.AddChallengeTestPage>();
            mauiAppBuilder.Services.AddSingleton<Pages.Tests.Exam.AddExamTestPage>();
            mauiAppBuilder.Services.AddSingleton<Pages.Tests.FinalExam.AddFinalExamTestPage>();

            mauiAppBuilder.Services.AddSingleton<Pages.Tests.Challenge.GetChallengeTestPage>();
            mauiAppBuilder.Services.AddSingleton<Pages.Tests.Exam.GetExamTestPage>();
            mauiAppBuilder.Services.AddSingleton<Pages.Tests.FinalExam.GetFinalExamTestPage>();

            return mauiAppBuilder;
        }
    }
}
