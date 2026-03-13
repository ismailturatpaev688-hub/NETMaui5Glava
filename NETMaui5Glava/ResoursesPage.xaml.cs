namespace NETMaui5Glava;

public partial class ResoursesPage : ContentPage
{
	public ResoursesPage()
	{
		InitializeComponent();
	}
	private void Picker_SelectedIndexChanged(object sender, EventArgs e)
	{
		string[] arr = ["Новое значение 1", "Новое значение 2", "Новое значение 3", "Новое значение 4"];
		Resources["pickerElemnts"] = arr;
	}
}