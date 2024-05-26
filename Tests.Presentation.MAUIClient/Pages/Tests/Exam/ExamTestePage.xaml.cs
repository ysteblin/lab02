using Tests.Presentation.MAUIClient.ViewModels.Tests.Exam;

namespace Tests.Presentation.MAUIClient.Pages.Tests.Exam;

public partial class ExamTestPage : ContentPage
{
	private readonly ExamTestViewModel _iCETestViewModel;
	public ExamTestPage(ExamTestViewModel iCETestViewModel)
	{
		InitializeComponent();

		BindingContext = _iCETestViewModel = iCETestViewModel;
	}
}
