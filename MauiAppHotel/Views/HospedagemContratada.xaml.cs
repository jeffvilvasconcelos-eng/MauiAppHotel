using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada()
        {
            InitializeComponent();
        }
        
        private void Button_Clicked(object sender, EventArgs e )
        {         
            //Exemplo: Voltar para a página anterior
            
            Navigation.PopAsync();
        
             /* private async void BtnSobre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(new Sobre());*/
        }
    }

}