namespace MauiApp6
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void OkClicked(object sender, EventArgs e)
        {
            // Kay?t i?lemleri yap?l?yor...
            Navigation.PopAsync();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            // Hiç bir i?lem yapmadan geri dönüyor...
            Navigation.PopAsync();
        }
    }
}
