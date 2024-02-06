namespace HomeCleaningTemplate.Pages;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Application.Current.MainPage.Navigation.PushAsync(new TutorialPage());
		//Shell.Current.GoToAsync(nameof(TutorialPage));
    }
}