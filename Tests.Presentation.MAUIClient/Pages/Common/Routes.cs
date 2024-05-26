using Tests.Presentation.MAUIClient.Pages.Tests;
using Tests.Presentation.MAUIClient.Pages.Tests.Challenge;
using Tests.Presentation.MAUIClient.Pages.Tests.Exam;
using Tests.Presentation.MAUIClient.Pages.Tests.FinalExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Presentation.MAUIClient.Pages.Common
{
    public static class Routes
    {
        public static string MainRoute { get; } = nameof(MainPage);

        public static string ChallengeTestPageRoute { get; } = nameof(ChallengeTestPage);
        public static string ExamTestPageRoute { get; } = nameof(ExamTestPage);
        public static string FinalExamTestPageRoute { get; } = nameof(FinalExamTestPage);

        public static string AddChallengeTestPageRoute { get; } = nameof(AddChallengeTestPage);
        public static string AddExamTestPageRoute { get; } = nameof(AddExamTestPage);
        public static string AddFinalExamTestPageRoute { get; } = nameof(AddFinalExamTestPage);

        public static string GetChallengeTestPageRoute { get; } = nameof(GetChallengeTestPage);
        public static string GetExamTestPageRoute { get; } = nameof(GetExamTestPage);
        public static string GetFinalExamTestPageRoute { get; } = nameof(GetFinalExamTestPage);

    }
}
