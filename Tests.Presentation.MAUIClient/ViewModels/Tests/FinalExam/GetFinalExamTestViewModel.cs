using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tests.Application.Common.Interfaces.Services;
using Tests.Presentation.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Presentation.MAUIClient.ViewModels.Tests.FinalExam
{
    public partial class GetFinalExamTestViewModel : BaseViewModel
    {
        private readonly IFinalExamService _finalExamService;

        public GetFinalExamTestViewModel(IFinalExamService finalExamService)
        {
            _finalExamService = finalExamService;
        }

        [ObservableProperty]
        List<Domain.Entities.FinalExam> testList = new();

        [ObservableProperty]
        private string search;

        public void ReloadList()
        {
            TestList = _finalExamService.GetList(Search);
        }

        [RelayCommand]
        public void SearchList()
        {

            ReloadList();
        }
    }
}
