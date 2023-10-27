namespace AltShiftApp {
    public partial class App : Application {
        public App() {

            // Todo: Enforce light mode
            //App.Current.UserAppTheme = AppTheme.Light;

            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}