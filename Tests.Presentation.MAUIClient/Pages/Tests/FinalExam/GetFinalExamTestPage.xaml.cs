using Tests.Presentation.MAUIClient.ViewModels.Tests.FinalExam;

namespace Tests.Presentation.MAUIClient.Pages.Tests.FinalExam;

public partial class GetFinalExamTestPage : ContentPage
{
    private readonly GetFinalExamTestViewModel _getFinalExamTestViewModel;
    public GetFinalExamTestPage(GetFinalExamTestViewModel getFinalExamTestViewModel)
    {
        InitializeComponent();

        BindingContext = _getFinalExamTestViewModel = getFinalExamTestViewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _getFinalExamTestViewModel.ReloadList();
    }
}