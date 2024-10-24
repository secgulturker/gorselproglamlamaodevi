namespace MauiApp6
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Kay?t i?lemleri
            //if (!......)
            //{
            //    return;
            //}
            App.Current.MainPage = new AppShell();
        }

        private void Kaydolma_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }
    }
}
