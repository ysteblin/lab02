using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Tests.Presentation.MAUIClient.Pages.Common;
using Tests.Presentation.MAUIClient.ViewModels.Base;

namespace Tests.Presentation.MAUIClient.ViewModels.Tests.FinalExam
{
    public partial class FinalExamTestViewModel : BaseViewModel
    {
        [RelayCommand]
        public async void GoToAddFinalExamTestPage()
        {

            await Shell.Current.GoToAsync(Routes.AddFinalExamTestPageRoute);
        }


        [RelayCommand]
        public async void GoToGetFinalExamTestPage()
        {

            await Shell.Current.GoToAsync(Routes.GetFinalExamTestPageRoute);
        }
    }
}
