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

namespace Tests.Presentation.MAUIClient.ViewModels.Tests.Challenge
{
    public partial class AddChallengeTestViewModel : BaseViewModel
    {
       
        [ObservableProperty]
        private Domain.Entities.Challenge test = new();
        private readonly IChallengeService _challengeService;

        public AddChallengeTestViewModel(IChallengeService challengeService) { _challengeService = challengeService; }

        [RelayCommand]
        public async Task AddChallengeTest()
        {
            Guid id = Guid.NewGuid();
            _challengeService.Add(new Domain.Entities.Challenge()
            {
                Id = id,
                Name = test.Name,
                Topic = test.Topic,
                TestTime = test.TestTime,
                Location = test.Location,
                Date = test.Date,
                PassingScore = test.PassingScore
            });

            await Shell.Current.GoToAsync("..");
        }
    }
}
