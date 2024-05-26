using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tests.Application.Common.Interfaces.Services;
using Tests.Presentation.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Presentation.MAUIClient.ViewModels.Tests.Challenge
{
    public partial class GetChallengeTestViewModel : BaseViewModel
    {
        private readonly IChallengeService _challengeService;

        public GetChallengeTestViewModel(IChallengeService challengeService)
        {
            _challengeService = challengeService;
        }

        [ObservableProperty]
        List<Domain.Entities.Challenge> testList = new();

        [ObservableProperty]
        private string search;

        public void ReloadList()
        {
            TestList = _challengeService.GetList(Search);
        }

        [RelayCommand]
        public void SearchList()
        {

            ReloadList();
        }
    }
}
