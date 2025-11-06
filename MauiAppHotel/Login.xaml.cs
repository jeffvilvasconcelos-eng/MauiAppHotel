namespace MauiAppHotel;
public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            List<DadosUsuario> lista_Usuarios = new List<DadosUsuario>
            {
                new DadosUsuario()
                {
                    Usuario = "admin",
                    Senha = "admin"
                }
            };

            DadosUsuario dados_digitados = new()
            {
                Usuario = txt_usuario.Text,
                Senha = txt_senha.Text
            };

            // LINQ para verificar se o usuário existe na lista
            if (lista_Usuarios.Any(u => u.Usuario == dados_digitados.Usuario && u.Senha == dados_digitados.Senha))
            {
                await SecureStorage.Default.SetAsync("usuario_logado", dados_digitados.Usuario);

               
                var window = Application.Current?.Windows.FirstOrDefault();
                if (window != null)
                {
                    window.Page = new Protegida();
                }
                else
                {
                    throw new Exception("Nenhuma janela ativa encontrada para alterar a página.");
                }
            }
            else
            {
                throw new Exception("Usuário ou senha inválidos!");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Fechar");
        }
    }


}// fecha class