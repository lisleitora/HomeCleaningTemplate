namespace HomeCleaningTemplate.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
        
	}

    private async void GoCalendar(object sender, EventArgs e)
    {
    //    Application.Current.MainPage.Navigation.PushAsync(new CalendarPage());
    pgCalendarPage.IsVisible = true;
    }

    private void GoMyPlan(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new MyPlanPage());
    }
}