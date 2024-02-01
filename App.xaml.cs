using HomeCleaningTemplate.Pages;

namespace HomeCleaningTemplate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StartPage();
        }
    }
}
