using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tests.Application.Common.Interfaces.Services;
using Tests.Presentation.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Presentation.MAUIClient.ViewModels.Tests.Exam
{
    public partial class GetExamTestViewModel : BaseViewModel
    {
        private readonly IExamService _examService;

        public GetExamTestViewModel(IExamService examService)
        {
            _examService = examService;
        }

        [ObservableProperty]
        List<Domain.Entities.Exam> testList = new();

        [ObservableProperty]
        private string search;

        public void ReloadList()
        {
            TestList = _examService.GetList(Search);
        }

        [RelayCommand]
        public void SearchList()
        {

            ReloadList();
        }
    }
}
