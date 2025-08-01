namespace AppHotel.Views;

public partial class ContratarHospedagem : ContentPage
{
	App PropriedadesApp;
	public ContratarHospedagem()
	{
		InitializeComponent();
		PropriedadesApp = (App)Application.Current;
		pik_suite.ItemsSource = PropriedadesApp.listaQuartos;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync( new CalculoFinalHospedagem());
    }
}