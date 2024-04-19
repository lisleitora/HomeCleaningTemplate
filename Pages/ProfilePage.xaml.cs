namespace HomeCleaningTemplate.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
        
    }
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(200);
        pgCalendar.TranslationX = pgCalendar.Width;
        pgCalendar.TranslationY = pgCalendar.Height * -1;
    }
    private async void GoCalendar(object sender, EventArgs e)
    {
    //    Application.Current.MainPage.Navigation.PushAsync(new CalendarPage());
    pgCalendarPage.IsVisible = true;
        pgProfilePage.IsVisible = false;
        await Helpers.AppearRight(pgCalendar, true);
        await Helpers.BoingAppearUp(pgAssignments, true);
    }

    private void GoMyPlan(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new MyPlanPage());
    }
}