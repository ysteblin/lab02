using Tests.Presentation.MAUIClient.ViewModels.Tests.Challenge;

namespace Tests.Presentation.MAUIClient.Pages.Tests.Challenge;

public partial class GetChallengeTestPage : ContentPage
{
	private readonly GetChallengeTestViewModel _getChallengeTestViewModel;
	public GetChallengeTestPage(GetChallengeTestViewModel getChallengeTestViewModel)
	{
		InitializeComponent();

		BindingContext = _getChallengeTestViewModel = getChallengeTestViewModel;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _getChallengeTestViewModel.ReloadList();
    }
}