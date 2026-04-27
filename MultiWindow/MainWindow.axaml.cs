using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MultiWindow
{
    public partial class MainWindow : Window
    {
        private Window1? _window1;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenNormal(object ? sender, RoutedEventArgs e)
        {
            if (_window1 == null)
            {
                _window1 = new Window1();
                _window1.Closed += (s, e) => _window1 = null;
                _window1.Show();
                _window1.Activate();
            }
            else
            {
                _window1.Activate();
            }
        }
        private async void OpenModal(object? sender, RoutedEventArgs e)
        {
            var window = new Window1();
            string? result = await window.ShowDialog<string>(this);
            if (!string.IsNullOrEmpty(result))
            {
                Output.Text = $"Result: {result}";
            }
        }
    }
}