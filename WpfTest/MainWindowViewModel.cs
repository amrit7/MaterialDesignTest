using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
