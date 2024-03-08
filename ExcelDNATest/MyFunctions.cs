using ExcelDna.Integration;

namespace ExcelDNATest;


public class MyFunctions
{
    [ExcelFunction(Description="My first .NET function")]
    public static string SayHello(string name)
    {
        //var frm = new MainWindow();
        //frm.show()

        return "Hello " + name;
    }
}