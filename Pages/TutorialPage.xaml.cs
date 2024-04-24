namespace HomeCleaningTemplate.Pages;

public partial class TutorialPage : ContentPage
{
    bool isFirst = true;
	public TutorialPage()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(200);

        pgDownThing.TranslationY = pgDownThing.Height;
        pgRightImage.TranslationX = pgRightImage.Width;
        pgRightImage.TranslationY = pgRightImage.Width * -1;

        if (!isFirst)
        await Helpers.Expand(pgStart, pgBackButton, true);

        isFirst = false;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new ProfilePage());

    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Helpers.Shrink(pgStart, pgBackButton, true);
        await Helpers.BoingAppearUp(pgDownThing, true); 
        await Helpers.AppearRight(pgRightImage, true);
    }
    private async void Back(object sender, EventArgs e)
    {
        await Task.Delay(200);
        pgDownThing.TranslationY = pgDownThing.Height;
        pgRightImage.TranslationX = pgRightImage.Height;
        pgRightImage.TranslationY = pgRightImage.Width*-1;
        await Helpers.Expand(pgStart, pgBackButton, true);
    }
}