namespace HomeCleaningTemplate.Pages;

public partial class TutorialPage : ContentPage
{
	public TutorialPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new ProfilePage());

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new StartPage());

    }
}