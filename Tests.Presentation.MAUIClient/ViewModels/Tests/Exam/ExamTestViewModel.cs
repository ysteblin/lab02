using CommunityToolkit.Mvvm.Input;
using Tests.Presentation.MAUIClient.Pages.Common;
using Tests.Presentation.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Presentation.MAUIClient.ViewModels.Tests.Exam
{
    public partial class ExamTestViewModel : BaseViewModel
    {
        [RelayCommand]
        public async void GoToAddExamTestPage()
        {

            await Shell.Current.GoToAsync(Routes.AddExamTestPageRoute);
        }


        [RelayCommand]
        public async void GoToGetExamTestPage()
        {

            await Shell.Current.GoToAsync(Routes.GetExamTestPageRoute);
        }
    }
}
