using System.Text;

namespace AltShiftApp;

public partial class MainPage : ContentPage {

    public MainPage() {
        InitializeComponent();
    }

    private void OnTranslateBtnClicked(object sender, EventArgs e) {
        
        // Todo: <Medium> - Implement this for keystrokes instead of input string to handle edge cases with numbers etc.
        var input = InputEditor.Text;

        // Todo: <Medium> - Implement configurable keyboard maps
        var keyMap = Data.KeyMapProvider.us2cz;

        // Note: Remap each character with the map
        var stringBuilder = new StringBuilder();
        foreach (char key in input) {
            if (keyMap.ContainsKey(key)) {
                stringBuilder.Append(keyMap[key]);
            } else {
                stringBuilder.Append(key);
            }
        }

        OutputEditor.Text = stringBuilder.ToString();

    }
}