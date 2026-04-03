namespace NETMaui5Glava;

public partial class VisualStateManagerPage : ContentPage
{
	public VisualStateManagerPage()
	{
		InitializeComponent();
		
		/* Привязка в cs
		textLabel.BindingContext = textEdit;
		textLabel.SetBinding(Label.TextProperty, "Text");
		*/
	}

	

	// Использование менеджера визуальных состояний
	/*
	private void Entry_TextChanged(object sender, TextChangedEventArgs e)
	{
		if (int.TryParse(e.NewTextValue, out int value))
		{
			if (VisualStateManager.GoToState(NumberOnly, "Valid") == false)
				throw new Exception("Error");
		}
		else
		{
			VisualStateManager.GoToState(NumberOnly, "Invalid");
		}
	}*/
}