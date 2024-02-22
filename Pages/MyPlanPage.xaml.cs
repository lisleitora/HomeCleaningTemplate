namespace HomeCleaningTemplate.Pages;

public partial class MyPlanPage : ContentPage
{
	public MyPlanPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    { bool click = PgPink2.IsVisible;
        if (click == true)
       { 
        PgPink2.IsVisible = false;
            click = false;
        }
        else
        {
            PgPink2.IsVisible = true;
            click = true;
        }
    }

    private void Button_Clicked2(object sender, EventArgs e)
    {
        bool click = PgPink1.IsVisible;
        if (click == true)
        {
            PgPink1.IsVisible = false;
            click = false;
        }
        else
        {
            PgPink1.IsVisible = true;
            click = true;
        }
    }

    private void Weekly(object sender, EventArgs e)
    {
        bool clicked =! pgWeeklyOn.IsVisible;
        if (clicked == true)
        {
            pgWeeklyOn.IsVisible = true;
            pgMonthlyOn.IsVisible = false;
            pgBiWeeklyOn.IsVisible = false;
            clicked = false;
        }
        else
        {
            pgWeeklyOn.IsVisible = false;
            clicked = true;
        }
    }
    private void BiWeekly(object sender, EventArgs e)
    {
        bool clicked = !pgBiWeeklyOn.IsVisible;
        if (clicked == true)
        {
            pgWeeklyOn.IsVisible = false;
            pgMonthlyOn.IsVisible = false;
            pgBiWeeklyOn.IsVisible = true;
            clicked = false;
        }
        else
        {
            pgBiWeeklyOn.IsVisible = false;
            clicked = true;
        }
    }
    private void Monthly(object sender, EventArgs e)
    {

        bool clicked = !pgMonthlyOn.IsVisible;
        if (clicked == true)
        {
            pgWeeklyOn.IsVisible = false;
            pgMonthlyOn.IsVisible = true;
            pgBiWeeklyOn.IsVisible = false;
            clicked = false;
        }
        else
        {
            pgMonthlyOn.IsVisible = false;
            clicked = true;
        }
    }
}