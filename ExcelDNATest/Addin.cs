using ExcelDna.Integration;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ExcelDNATest;

public class Addin: IExcelAddIn
{
    public void AutoOpen()
    {
        InitializeMaterialDesign();
    }

    public void AutoClose()
    {
    }

    void InitializeMaterialDesign()
    {
        // Create dummy objects to force the MaterialDesign assemblies to be loaded
        // from this assembly, which causes the MaterialDesign assemblies to be searched
        // relative to this assembly's path or loaded from the packed add-in.
        var card = new Card();
        var hue = new Hue("Dummy", Colors.Black, Colors.White);
    }
}
