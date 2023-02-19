using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MyFirstAvaloniaApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent1();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent1()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
