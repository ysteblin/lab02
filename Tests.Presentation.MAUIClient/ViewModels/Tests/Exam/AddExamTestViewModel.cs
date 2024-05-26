using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Domain.Entities;
using CommunityToolkit.Mvvm.Input;
using Tests.Application.Common.Interfaces.Services;
using Tests.Presentation.MAUIClient.ViewModels.Base;

namespace Tests.Presentation.MAUIClient.ViewModels.Tests.Exam
{
    public partial class AddExamTestViewModel : BaseViewModel
    {

        [ObservableProperty]
        private Domain.Entities.Exam test = new();
        private readonly IExamService _examService;

        public AddExamTestViewModel(IExamService examService) { _examService = examService; }

        [RelayCommand]
        public async Task AddExamTest()
        {
            Guid id = Guid.NewGuid();
            _examService.Add(new Domain.Entities.Exam()
            {
                Id = id,
                Name = test.Name,
                Topic = test.Topic,
                TestTime = test.TestTime,
                DifficultyLevel = test.DifficultyLevel,
                QuestionsCount = test.QuestionsCount,
                PassingScore = test.PassingScore
            });

            await Shell.Current.GoToAsync("..");
        }
    }
}
