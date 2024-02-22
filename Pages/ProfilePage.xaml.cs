namespace HomeCleaningTemplate.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private void GoCalendar(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new CalendarPage());
    }

    private void GoMyPlan(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new MyPlanPage());
    }
}