namespace AvaloniaInside.Shell.Issue64;

public partial class Modal2 : Page
{
    public Modal2()
    {
        InitializeComponent();
    }

    private async void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        await Navigator?.BackAsync();
    }
}