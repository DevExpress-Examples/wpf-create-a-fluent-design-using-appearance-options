Imports DevExpress.Xpf.Core
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Media

Namespace FluentDesignTemplate
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application

		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			Dim custompalette = New ThemePalette("CustomPalette")
			custompalette.SetColor("Foreground", Colors.White)
			custompalette.SetColor("Focused", DirectCast(ColorConverter.ConvertFromString("#A04B647A"), Color))
			custompalette.SetColor("HoverBackground", DirectCast(ColorConverter.ConvertFromString("#1FFFFFFF"), Color))
			custompalette.SetColor("HoverBorder", DirectCast(ColorConverter.ConvertFromString("#1FFFFFFF"), Color))
			custompalette.SetColor("Border", DirectCast(ColorConverter.ConvertFromString("#4F0B0A15"), Color))
			custompalette.SetColor("SelectionBackground", DirectCast(ColorConverter.ConvertFromString("#5E8B99A3"), Color))
			custompalette.SetColor("SelectionBorder", DirectCast(ColorConverter.ConvertFromString("#5E8B99A3"), Color))
			custompalette.SetColor("ControlLight.SelectionBackground", DirectCast(ColorConverter.ConvertFromString("#5E8B99A3"), Color))
			custompalette.SetColor("Control.SelectionBackground", DirectCast(ColorConverter.ConvertFromString("#5E8B99A3"), Color))
			custompalette.SetColor("Control.HoverBackground", DirectCast(ColorConverter.ConvertFromString("#2E8B99A3"), Color))
			custompalette.SetColor("Editor.Background", DirectCast(ColorConverter.ConvertFromString("#FF70787E"), Color))
			custompalette.SetColor("Window.Background", DirectCast(ColorConverter.ConvertFromString("#FF70787E"), Color))
			custompalette.SetColor("Button.Background", DirectCast(ColorConverter.ConvertFromString("#4F0B0A15"), Color))
			custompalette.SetColor("SelectionForeground", DirectCast(ColorConverter.ConvertFromString("White"), Color))
			Dim customtheme = Theme.CreateTheme(custompalette, Theme.Office2019Black)
			Theme.RegisterTheme(customtheme)
			ApplicationThemeHelper.ApplicationThemeName = customtheme.Name

			MyBase.OnStartup(e)
		End Sub
	End Class
End Namespace
