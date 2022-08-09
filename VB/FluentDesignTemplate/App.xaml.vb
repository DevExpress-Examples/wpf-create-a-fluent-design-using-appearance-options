Imports DevExpress.Xpf.Core
Imports System.Windows
Imports System.Windows.Media

Namespace FluentDesignTemplate

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            Dim custompalette = New ThemePalette("CustomPalette")
            custompalette.SetColor("Foreground", Colors.White)
            custompalette.SetColor("Focused", CType(ColorConverter.ConvertFromString("#A04B647A"), Color))
            custompalette.SetColor("HoverBackground", CType(ColorConverter.ConvertFromString("#1FFFFFFF"), Color))
            custompalette.SetColor("HoverBorder", CType(ColorConverter.ConvertFromString("#1FFFFFFF"), Color))
            custompalette.SetColor("Border", CType(ColorConverter.ConvertFromString("#4F0B0A15"), Color))
            custompalette.SetColor("SelectionBackground", CType(ColorConverter.ConvertFromString("#5E8B99A3"), Color))
            custompalette.SetColor("SelectionBorder", CType(ColorConverter.ConvertFromString("#5E8B99A3"), Color))
            custompalette.SetColor("ControlLight.SelectionBackground", CType(ColorConverter.ConvertFromString("#5E8B99A3"), Color))
            custompalette.SetColor("Control.SelectionBackground", CType(ColorConverter.ConvertFromString("#5E8B99A3"), Color))
            custompalette.SetColor("Control.HoverBackground", CType(ColorConverter.ConvertFromString("#2E8B99A3"), Color))
            custompalette.SetColor("Editor.Background", CType(ColorConverter.ConvertFromString("#FF70787E"), Color))
            custompalette.SetColor("Window.Background", CType(ColorConverter.ConvertFromString("#FF70787E"), Color))
            custompalette.SetColor("Button.Background", CType(ColorConverter.ConvertFromString("#4F0B0A15"), Color))
            custompalette.SetColor("SelectionForeground", CType(ColorConverter.ConvertFromString("White"), Color))
            Dim customtheme = Theme.CreateTheme(custompalette, Theme.Office2019Black)
            Theme.RegisterTheme(customtheme)
            ApplicationThemeHelper.ApplicationThemeName = customtheme.Name
            MyBase.OnStartup(e)
        End Sub
    End Class
End Namespace
