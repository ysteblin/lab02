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

namespace Tests.Presentation.MAUIClient.ViewModels.Tests.FinalExam
{
    public partial class AddFinalExamTestViewModel : BaseViewModel
    {

        [ObservableProperty]
        private Domain.Entities.FinalExam test = new();
        private readonly IFinalExamService _finalExamService;

        public AddFinalExamTestViewModel(IFinalExamService finalExamService) { _finalExamService = finalExamService; }

        [RelayCommand]
        public async Task AddFinalExamTest()
        {
            Guid id = Guid.NewGuid();
            _finalExamService.Add(new Domain.Entities.FinalExam()
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
