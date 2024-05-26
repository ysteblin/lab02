using Tests.Presentation.MAUIClient.ViewModels.Tests.Exam;

namespace Tests.Presentation.MAUIClient.Pages.Tests.Exam;

public partial class GetExamTestPage : ContentPage
{
    private readonly GetExamTestViewModel _getExamTestViewModel;
    public GetExamTestPage(GetExamTestViewModel getExamTestViewModel)
    {
        InitializeComponent();

        BindingContext = _getExamTestViewModel = getExamTestViewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _getExamTestViewModel.ReloadList();
    }
}