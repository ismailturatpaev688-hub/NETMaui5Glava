namespace NETMaui5Glava
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            await Browser.Default.OpenAsync("https://Csharp.webdelphi.ru");
        }
    }
}
