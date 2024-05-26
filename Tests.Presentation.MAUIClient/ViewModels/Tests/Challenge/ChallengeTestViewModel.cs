using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Presentation.MAUIClient.Pages.Common;
using CommunityToolkit.Mvvm.Input;
using Tests.Presentation.MAUIClient.ViewModels.Base;

namespace Tests.Presentation.MAUIClient.ViewModels.Tests.Challenge
{
    public partial class ChallengeTestViewModel : BaseViewModel
    {
        [RelayCommand]
        public async void GoToAddChallengeTestPage()
        {

            await Shell.Current.GoToAsync(Routes.AddChallengeTestPageRoute);
        }


        [RelayCommand]
        public async void GoToGetChallengeTestPage()
        {

            await Shell.Current.GoToAsync(Routes.GetChallengeTestPageRoute);
        }
    }
}
