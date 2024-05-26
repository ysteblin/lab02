using Tests.Presentation.MAUIClient.ViewModels.Tests.FinalExam;

namespace Tests.Presentation.MAUIClient.Pages.Tests.FinalExam;

public partial class AddFinalExamTestPage : ContentPage
{
    private readonly AddFinalExamTestViewModel _addFinalExamTestViewModel;
    public AddFinalExamTestPage(AddFinalExamTestViewModel addFinalExamTestViewModel)
    {
        InitializeComponent();

        BindingContext = _addFinalExamTestViewModel = addFinalExamTestViewModel;
    }
}