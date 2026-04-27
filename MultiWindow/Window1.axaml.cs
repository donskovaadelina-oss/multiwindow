using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MultiWindow;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
    }
    public void Accept(object? sender, RoutedEventArgs e)
    {
        string result = Input.Text ?? "";
        this.Close(result);
    }
}