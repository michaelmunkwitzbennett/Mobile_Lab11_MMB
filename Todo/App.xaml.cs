using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Todo
{
    public partial class App : Application
    {
        static JokesItemDatabase database;

        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new TodoListPage());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            nav.BarTextColor = Color.White;

            MainPage = nav;
        }

        public static JokesItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new JokesItemDatabase();
                }
                return database;
            }
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}

