using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfTest;

public partial class MainWindowViewModel: ObservableObject
{
    public MainWindowViewModel() 
    {
    }


    [RelayCommand()]
    private void SetValue()
    {
        var test = HttpPostCall.SetTestValue();
    }
}
