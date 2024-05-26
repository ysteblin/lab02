using Tests.Domain.Entities.Base;


namespace Tests.Domain.Entities
{
    public class FinalExam : Test
    {
        public int DifficultyLevel { get; set; }

        public int QuestionsCount { get; set; }

        public int PassingScore { get; set; }
    }
}
