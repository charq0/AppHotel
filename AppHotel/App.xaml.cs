
using AppHotel.Models;

namespace AppHotel
{
    public partial class App : Application
    {
       public List<Quarto> listaQuartos = new List<Quarto>
       {
           new Quarto
           {
               Descricao="Suite de Luxo",
               PrecoAdulto= 111,
               PrecoCrianca= 90
           },
            new Quarto
           {
               Descricao="Suite Comum",
               PrecoAdulto= 80,
               PrecoCrianca= 50
           },
                  new Quarto
           {
               Descricao="Suite Economica",
               PrecoAdulto= 30,
               PrecoCrianca= 15
           },
       };
        public App()
        {
            InitializeComponent();
            MainPage= new NavigationPage(new Views.ContratarHospedagem());
            
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window= base.CreateWindow(activationState);
            window.Width = 400;
            window.Height= 700;
            return window;
        }
    }
}