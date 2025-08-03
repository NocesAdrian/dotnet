namespace HolyTodoList.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";
    public string Title { get; } = "HolyToDoList";
    // Buttons
    public string EnterButton { get; set; } = "Enter";
    public string DeleteButton { get; set; } = "Delete";

    // Text Content
    public string TodoContent { get; set; } = "None";
}
