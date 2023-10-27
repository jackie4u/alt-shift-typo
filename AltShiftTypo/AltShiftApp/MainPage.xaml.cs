namespace AltShiftApp {
    public partial class MainPage : ContentPage {

        public MainPage() {
            InitializeComponent();
        }

        private void OnTranslateBtnClicked(object sender, EventArgs e) {

            var input = InputEditor.Text;
            OutputEditor.Text = input;

        }
    }
}