using Tests.Presentation.MAUIClient.ViewModels.Tests.FinalExam;

namespace Tests.Presentation.MAUIClient.Pages.Tests.FinalExam;

public partial class FinalExamTestPage : ContentPage
{
	private readonly FinalExamTestViewModel _finalExamTestViewModel;
	public FinalExamTestPage(FinalExamTestViewModel finalExamTestViewModel)
	{
		InitializeComponent();

		BindingContext = _finalExamTestViewModel = finalExamTestViewModel;
	}
}