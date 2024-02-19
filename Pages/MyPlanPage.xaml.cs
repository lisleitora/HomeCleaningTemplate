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
}