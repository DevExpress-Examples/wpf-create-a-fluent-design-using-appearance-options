# How to Create a Unique Design for a WPF View using Appearance Options

This example demonstrates how to create the following view with DevExpress components:

![Alt text](Images/preview.png)


Here are the main controls used in the view:
1. ThemedWindow - the window with the acrylic effect 
2. AccordionControl - the navigation control on the left
3. MainMenuControl with bar items - the user menu in the top right corner
4. ListBoxEdit - the galleries in the main part
5. ButtonEdit - the search field in the window header


We used the following features to achieve this design:
1. Acrylic effect
```csharp
<dx:ThemedWindow AcrylicOpacity="0.6" AcrylicColor="#FF02111D" ... 
```
2. Reveal highlight effect
```csharp
<Style x:Key="accordionChildItemStyle" TargetType="{x:Type dxa:AccordionItem}">
    <Setter Property="dxwui:RevealHighlightOptions.Mode" Value="BackgroundAndBorder"/>
    <Setter Property="dxwui:RevealHighlightOptions.BackgroundColor" Value="#19E4D9D9"/>
    <Setter Property="dxwui:RevealHighlightOptions.BorderColor" Value="#FF615B5B"/>
    <Setter Property="dxwui:RevealHighlightOptions.BorderThickness" Value="1"/>
</Style>
```

3. Theme palettes:
```csharp
var custompalette = new ThemePalette("CustomPalette");
custompalette.SetColor("Foreground", Colors.White);
custompalette.SetColor("Focused", (Color)ColorConverter.ConvertFromString("#A04B647A"));
custompalette.SetColor("HoverBackground", 
//… 
var customtheme = Theme.CreateTheme(custompalette, Theme.Office2019Black);
Theme.RegisterTheme(customtheme);
ApplicationThemeHelper.ApplicationThemeName = customtheme.Name;
SVG image palettes:
<dx:WpfSvgPalette.Palette>
    <dx:WpfSvgPalette>
        <SolidColorBrush x:Key="Blue" Color="White"/>
        <SolidColorBrush x:Key="Black" Color="White"/>
        <SolidColorBrush x:Key="Yellow" Color="White"/>
        <SolidColorBrush x:Key="Red" Color="White"/>
        <SolidColorBrush x:Key="Green" Color="White"/>
    </dx:WpfSvgPalette>
</dx:WpfSvgPalette.Palette>
```

4. SimpleButtons with a corner radius:
```csharp
<dx:SimpleButton CornerRadius="2" 
```
5. The ThemedWindow.HeaderItems property to add elements to the window header.
