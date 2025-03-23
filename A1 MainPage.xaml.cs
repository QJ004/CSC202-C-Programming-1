namespace MauiApp1;

public partial class MainPage : ContentPage
// Public partial class MainPage: ContentPage.
// MainPage is a partial class that extends ContentPage, meaning it represents a screen in the app.

{
    int count = 0;
    // a private integer variable count is initialized to 0, it is used for tracking button clicks or another numeric value.

    public MainPage()
    {
        InitializeComponent();
        // Loads and initializes the UI defined in the corresponding XAML file and connects UI elements to C# code. 
    }

    private void BtnSubmit_Clicked(object sender, EventArgs e)
    // This is the object sender, refers to the object (the button) that triggers the event.
    // EventArg e contains additional event-related data.
    {
        string name = txtName.Text; 
        // Gets the text entered by the user in a text input field (textName).
        string age = txtAge.Text; 
        // Retrieving the age the user inputs and store it in the system.
        
        lblResults.Text = "Hello, " + name + "!";
        // Updates the text of a label (lblResults) to greet the user with their name.
        lblResults.Text = "Hello, " + name + "! You are " + age;
        // Updates the text of label to also greet them using their age.
    }
}