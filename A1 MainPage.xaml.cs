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
        displaygreeting();
    }
    private void BtnCalAge_Clicked(object sender, EventArgs e)
    // This is the object sender, refers to the object (the button) that triggers the event.
    // EventArg e contains additional event-related data.
    {
       displaygreeting(); 
    //    create and call a different function 
    }
    private void displaygreeting() 
    {
        string name = txtName.Text; 
        // Gets the text entered by the user in a text input field (textName).
        string age = txtAge.Text; 
        // Retrieving the age the user inputs and store it in the system.
        
        try{
        int iAge = Int32.Parse(age);
        if(name == "Quenton") 
        {
            lblResults.Text = generateMessage();
            // This means the system to  generate the message I want it to display for certain things
        } 
        else
        {
            lblResults.Text = "Hello, " + name + "! You are " + age;
        // Updates the text of label to also greet them using their age.
        }
         if (iAge < 21)
        {
           lblResults.Text = "Hello," + name + "! You are not old enough to drink."; 
        }
           else
           {
            lblResults.Text = "Hello, " + name + "! Would you like to try our new drinks on the menu?";
           }
        
       
    } catch(FormatException feex)
    // This is for what would happen if both situations in the if, else statement aren't applied.
    {
        lblResults.Text = "Format expection has happened" + feex.Message;
    } catch(Exception ex)
    {
        lblResults.Text = "An error has occured"+ ex.Message;
    } 
    }
    private string generateMessage()
    {
        return "Hello Quenton";  
        // Private string defines variable or method that can only be accessed within the same class
    }

}