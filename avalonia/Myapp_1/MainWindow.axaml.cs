using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using System;

namespace Myapp_1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
	
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
		if(double.TryParse(Celsius.Text, out double C) | double.TryParse(Farenheit.Text, out double F))
		{
			double Faren = C * (9d / 5d) + 32;
			double Cel = (F - 32)*(5d/9d);
			Result1.Text = $" = {Faren} Fareheit";
			Result2.Text = $" = {Cel} Celcius";
			Console.WriteLine($"C->F: {Faren}F, F->C: {Cel}");
		}
		else
		{
			Celsius.Text = "0";
			Farenheit.Text = "0";
		}
    }
}
