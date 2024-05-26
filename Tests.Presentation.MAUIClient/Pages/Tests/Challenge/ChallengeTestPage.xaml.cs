using Tests.Presentation.MAUIClient.ViewModels.Tests;
using Tests.Presentation.MAUIClient.ViewModels.Tests.Challenge;

namespace Tests.Presentation.MAUIClient.Pages.Tests.Challenge;

public partial class ChallengeTestPage : ContentPage
{
    private readonly ChallengeTestViewModel _diselTestViewModel;
	public ChallengeTestPage(ChallengeTestViewModel diselTestViewModel)
	{
		InitializeComponent();

        BindingContext = _diselTestViewModel = diselTestViewModel;
	}
}

