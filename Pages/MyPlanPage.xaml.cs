namespace HomeCleaningTemplate.Pages;

public partial class MyPlanPage : ContentPage
{
	public MyPlanPage()
	{
		InitializeComponent();
    }

    private async void UpKeepButton(object sender, EventArgs e)
    { bool click = PgPink2.IsVisible;
        if (click == true)
       {
            pgInitialImage.FadeTo(.3, 1000);
            pgInitialImage.ScaleTo(1, 1000);
            PgPink2.IsVisible = false;
            click = false;
        }
        else
        {
            Helpers.Balanga(pgInitialImage);
            PgPink2.IsVisible = true;
            click = true;
        }
    }

    private void InitialButton(object sender, EventArgs e)
    {
        bool click = PgPink1.IsVisible;
        if (click == true)
        {
            PgPink1.IsVisible = false;
            click = false;
        }
        else
        {
            Helpers.Balanga(pgInitialImage);
            PgPink1.IsVisible = true;
            click = true;
        }
    }

    private async void Weekly(object sender, EventArgs e)
    {
        bool clicked =! pgWeeklyOn.IsVisible;
        if (clicked == true)
        { 
            pgWeeklyOff.IsVisible = false;
            pgWeeklyOn.IsVisible = true;
            pgMonthlyOn.IsVisible = false;
            pgBiWeeklyOn.IsVisible = false;
            pgMonthlyOff.IsVisible = true;
            pgBiWeeklyOff.IsVisible = true;
           await Helpers.Rotate(pgWeeklyOn, true);
            clicked = false;
        }
        else
        {
            pgWeeklyOff.IsVisible = true;
            pgWeeklyOn.IsVisible = false;
            await Helpers.Rotate(pgWeeklyOff, false);
            clicked = true;
        }
    }
    private async void BiWeekly(object sender, EventArgs e)
    {
        bool clicked = !pgBiWeeklyOn.IsVisible;
        if (clicked == true)
        {
            pgBiWeeklyOff.IsVisible = false;
            pgWeeklyOn.IsVisible = false;
            pgMonthlyOn.IsVisible = false;
            pgBiWeeklyOn.IsVisible = true;
            pgMonthlyOff.IsVisible = true;
            pgWeeklyOff.IsVisible = true;
           await Helpers.Rotate(pgBiWeeklyOn, true);
            clicked = false;
        }
        else
        {
            pgBiWeeklyOff.IsVisible = true;
            pgBiWeeklyOn.IsVisible = false;
           await Helpers.Rotate(pgBiWeeklyOff,false);
            clicked = true;
        }
    }
    private async void Monthly(object sender, EventArgs e)
    {

        bool clicked = !pgMonthlyOn.IsVisible;
        if (clicked == true)
        {
            
            pgMonthlyOff.IsVisible = false;
            pgWeeklyOn.IsVisible = false;
            pgMonthlyOn.IsVisible = true;
            pgBiWeeklyOn.IsVisible = false;
            pgBiWeeklyOff.IsVisible = true;
            pgWeeklyOff.IsVisible = true;
            await Helpers.Rotate(pgMonthlyOn,true);
            clicked = false;
        }
        else
        {
            pgMonthlyOff.IsVisible = true;
            pgMonthlyOn.IsVisible = false;
           await Helpers.Rotate(pgMonthlyOff,false);
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
