namespace MauiAppHotel;

public partial class Protegida : ContentPage
{
	public Protegida()
	{
		InitializeComponent();
		string? usuario_logado = null;
			
			Task.Run(async () =>
			{ 
				usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");
				lbl_boasvindas.Text = $"Seja bem-vindo!";
            });
}
	private async void Button_Clicked(object sender, EventArgs e)
	{
		bool confirm = await DisplayAlert("Tem Certeza?", "Deseja realmente sair?", "Sim", "Não");
		if (confirm)
		{
			SecureStorage.Default.Remove("usuario_logado");
			App.Current.MainPage = new Login();
            
        }
    }
}