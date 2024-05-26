using Tests.Presentation.MAUIClient.ViewModels.Tests.Challenge;

namespace Tests.Presentation.MAUIClient.Pages.Tests.Challenge;

public partial class AddChallengeTestPage : ContentPage
{
	private readonly AddChallengeTestViewModel _addChallengeTestViewModel;
	public AddChallengeTestPage(AddChallengeTestViewModel addChallengeTestViewModel)
	{
		InitializeComponent();

		BindingContext = _addChallengeTestViewModel = addChallengeTestViewModel;
	}
}