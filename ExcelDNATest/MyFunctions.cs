using ExcelDna.Integration;
using WpfTest;

namespace ExcelDNATest;


public class MyFunctions
{
    [ExcelFunction(Description="My first .NET function")]
    public static string SayHello(string name)
    {
        var frm = new MainWindow();
        frm.Show();


        return "Hello " + name;
    }
}