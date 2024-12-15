namespace AvaloniaInside.Shell.Issue64;

public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Navigator?.NavigateAsync("/modal1");
    }
}