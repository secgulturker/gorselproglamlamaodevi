namespace MauiApp6
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();  // XAML bileşenlerini yüklemek için
            Routing.RegisterRoute("CalculatorPage", typeof(CalculatorPage));
        }
    }
}