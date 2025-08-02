using AppHotel.Models;

namespace AppHotel.Views;

public partial class ContratarHospedagem : ContentPage
{
	App PropriedadesApp;
	public ContratarHospedagem()
	{
		InitializeComponent();
		PropriedadesApp = (App)Application.Current;
		pik_suite.ItemsSource = PropriedadesApp.listaQuartos;

		dtpik_checkin.MinimumDate = DateTime.Now;
		dtpik_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 2, DateTime.Now.Day);

		dtpik_checkout.MinimumDate = dtpik_checkin.Date.AddDays(1);
		dtpik_checkout.MaximumDate = dtpik_checkin.Date.AddMonths(2);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		
			try
			{
				Hospedagem h = new Hospedagem
				{
					
					quartoselecionado = (Quarto)pik_suite.SelectedItem,
					QntAdulto = Convert.ToInt32(step_adultos.Value),
					QntCrianca = Convert.ToInt32(step_criança.Value),
					DataCheckin = dtpik_checkin.Date,
					DataCheckout = dtpik_checkout.Date,

					
				};

				await Navigation.PushAsync(new CalculoFinalHospedagem()
				{
				
					BindingContext = h,

				});

			}
			catch (Exception ex)
			{
				DisplayAlert("Ops", "Preencha todos os campos", "Ok");
			}
		
	
    }

    private void dtpik_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento= sender as DatePicker;

		DateTime dia = elemento.Date;

		dtpik_checkout.MinimumDate= dia.AddDays(1);
		dtpik_checkout.MaximumDate= dia.AddMonths(2);
    }
}