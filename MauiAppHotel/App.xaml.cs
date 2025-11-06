using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
            {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiarioAdulto = 110.0,
                ValorDiarioCrianca = 55.00
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiarioAdulto = 80.0,
                ValorDiarioCrianca = 40.00
            },
            new Quarto()
            {
                Descricao = "Suíte Simples",
                ValorDiarioAdulto = 65.0,
                ValorDiarioCrianca = 30.00
            },
            new Quarto()
            {
                Descricao = "Quarto Simples",
                ValorDiarioAdulto = 45.0,
                ValorDiarioCrianca = 20.00
            },
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}