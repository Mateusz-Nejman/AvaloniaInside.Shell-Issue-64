namespace AvaloniaInside.Shell.Issue64;

public partial class Modal1 : Page
{
    public Modal1()
    {
        InitializeComponent();
    }

    private async void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        await Navigator?.NavigateAsync("/modal2");
    }
}