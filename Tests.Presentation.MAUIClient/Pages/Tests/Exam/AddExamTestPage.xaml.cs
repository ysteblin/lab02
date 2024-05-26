using Tests.Presentation.MAUIClient.ViewModels.Tests.Exam;

namespace Tests.Presentation.MAUIClient.Pages.Tests.Exam;

public partial class AddExamTestPage : ContentPage
{
    private readonly AddExamTestViewModel _addExamTestViewModel;
    public AddExamTestPage(AddExamTestViewModel addExamTestViewModel)
    {
        InitializeComponent();

        BindingContext = _addExamTestViewModel = addExamTestViewModel;
    }
}