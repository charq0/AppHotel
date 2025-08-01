namespace AppHotel.Views;

public partial class CalculoFinalHospedagem : ContentPage
{
	public CalculoFinalHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}
		catch(Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}
    }
}