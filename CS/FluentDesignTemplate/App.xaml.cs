using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace FluentDesignTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e) {
            var custompalette = new ThemePalette("CustomPalette");
            custompalette.SetColor("Foreground", Colors.White);
            custompalette.SetColor("Focused", (Color)ColorConverter.ConvertFromString("#A04B647A"));
            custompalette.SetColor("HoverBackground", (Color)ColorConverter.ConvertFromString("#1FFFFFFF"));
            custompalette.SetColor("HoverBorder", (Color)ColorConverter.ConvertFromString("#1FFFFFFF"));
            custompalette.SetColor("Border", (Color)ColorConverter.ConvertFromString("#4F0B0A15"));
            custompalette.SetColor("SelectionBackground", (Color)ColorConverter.ConvertFromString("#5E8B99A3"));
            custompalette.SetColor("SelectionBorder", (Color)ColorConverter.ConvertFromString("#5E8B99A3"));
            custompalette.SetColor("ControlLight.SelectionBackground", (Color)ColorConverter.ConvertFromString("#5E8B99A3"));
            custompalette.SetColor("Control.SelectionBackground", (Color)ColorConverter.ConvertFromString("#5E8B99A3"));
            custompalette.SetColor("Control.HoverBackground", (Color)ColorConverter.ConvertFromString("#2E8B99A3"));
            custompalette.SetColor("Editor.Background", (Color)ColorConverter.ConvertFromString("#FF70787E"));
            custompalette.SetColor("Window.Background", (Color)ColorConverter.ConvertFromString("#FF70787E"));
            custompalette.SetColor("Button.Background", (Color)ColorConverter.ConvertFromString("#4F0B0A15"));
            custompalette.SetColor("SelectionForeground", (Color)ColorConverter.ConvertFromString("White"));
            var customtheme = Theme.CreateTheme(custompalette, Theme.Office2019Black);
            Theme.RegisterTheme(customtheme);
            ApplicationThemeHelper.ApplicationThemeName = customtheme.Name;

            base.OnStartup(e);
        }
    }
}
