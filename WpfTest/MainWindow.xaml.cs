using System.Windows;

namespace WpfTest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private MainWindowViewModel _viewModel { get; }

    public MainWindow()
    {
        _viewModel = new MainWindowViewModel();
        DataContext = _viewModel;

        InitializeComponent();
    }
}
