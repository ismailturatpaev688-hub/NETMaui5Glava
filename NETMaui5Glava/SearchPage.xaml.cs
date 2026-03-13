using NETMaui5Glava.Controls;

namespace NETMaui5Glava;

public partial class SearchPage : ContentPage
{
	public List<string> Pages = ["MainPage", "ShellPage", "SearchPage"];
	int count = 0;
	public SearchPage()
	{
		InitializeComponent();
        Search.Pages = Pages;
	}
}