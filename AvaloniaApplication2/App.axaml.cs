using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaApplication2.Service;
using AvaloniaApplication2.ViewModels;
using AvaloniaApplication2.Views;

namespace AvaloniaApplication2
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            base.OnFrameworkInitializationCompleted();
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var db = new Database();
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(db),
                };
            }
        }
    }
}