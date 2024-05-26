using Tests.Presentation.MAUIClient.Pages;
using Tests.Presentation.MAUIClient.Pages.Common;
using Tests.Presentation.MAUIClient.Pages.Tests;

namespace Tests.Presentation.MAUIClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        public void RegisterRoutes()
        {
            Routing.RegisterRoute(Routes.MainRoute, typeof(MainPage));
            Routing.RegisterRoute(Routes.ChallengeTestPageRoute, typeof(Pages.Tests.Challenge.ChallengeTestPage));
            Routing.RegisterRoute(Routes.ExamTestPageRoute, typeof(Pages.Tests.Exam.ExamTestPage));
            Routing.RegisterRoute(Routes.FinalExamTestPageRoute, typeof(Pages.Tests.FinalExam.FinalExamTestPage));

            Routing.RegisterRoute(Routes.AddChallengeTestPageRoute, typeof(Pages.Tests.Challenge.AddChallengeTestPage));
            Routing.RegisterRoute(Routes.AddExamTestPageRoute, typeof(Pages.Tests.Exam.AddExamTestPage));
            Routing.RegisterRoute(Routes.AddFinalExamTestPageRoute, typeof(Pages.Tests.FinalExam.AddFinalExamTestPage));

            Routing.RegisterRoute(Routes.GetChallengeTestPageRoute, typeof(Pages.Tests.Challenge.GetChallengeTestPage));
            Routing.RegisterRoute(Routes.GetExamTestPageRoute, typeof(Pages.Tests.Exam.GetExamTestPage));
            Routing.RegisterRoute(Routes.GetFinalExamTestPageRoute, typeof(Pages.Tests.FinalExam.GetFinalExamTestPage));

        }
    }
}
