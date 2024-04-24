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
        pgCalendar.TranslationX = this.WidthRequest;
        pgCalendar.TranslationY = pgCalendar.HeightRequest * -1;
        pgAssignments.TranslationY = this.HeightRequest;
    }
    private async void GoCalendar(object sender, EventArgs e)
    {
        //Application.Current.MainPage.Navigation.PushAsync(new CalendarPage());
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