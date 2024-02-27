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

    private void Button_Clicked3(object sender, EventArgs e)
    {
        bool click = PgPink3.IsVisible;
        if (click == true)
        {
            PgPink3.IsVisible = false;
            click = false;
        }
        else
        {
            PgPink3.IsVisible = true;
            click = true;
        }
    }
    private void Button_Clicked4(object sender, EventArgs e)
    {
        bool click = PgPink4.IsVisible;
        if (click == true)
        {
            PgPink4.IsVisible = false;
            click = false;
        }
        else
        {
            PgPink4.IsVisible = true;
            click = true;
        }
    }
    private void Button_Clicked5(object sender, EventArgs e)
    {
        bool click = PgPink5.IsVisible;
        if (click == true)
        {
            PgPink5.IsVisible = false;
            click = false;
        }
        else
        {
            PgPink5.IsVisible = true;
            click = true;
        }
    }
    private void Button_Clicked6(object sender, EventArgs e)
    {
        bool click = PgPink6.IsVisible;
        if (click == true)
        {
            PgPink6.IsVisible = false;
            click = false;
        }
        else
        {
            PgPink6.IsVisible = true;
            click = true;
        }
    }
    private void Button_Clicked7(object sender, EventArgs e)
    {
        bool click = PgPink7.IsVisible;
        if (click == true)
        {
            PgPink7.IsVisible = false;
            click = false;
        }
        else
        {
            PgPink7.IsVisible = true;
            click = true;
        }
    }
    private void Button_Clicked8(object sender, EventArgs e)
    {
        bool click = PgPink8.IsVisible;
        if (click == true)
        {
            PgPink8.IsVisible = false;
            click = false;
        }
        else
        {
            PgPink8.IsVisible = true;
            click = true;
        }
    }
}