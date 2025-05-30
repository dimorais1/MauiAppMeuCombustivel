using Microsoft.Maui.Controls;
using System;

namespace MauiAppMeuCombistivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            {
                try
                {
                    double etanol = Convert.ToDouble(txt_etanol.Text);
                    double gasolina = Convert.ToDouble(txt_gasolina.Text);
                    string msg = "";
                    string marca = txt_marca.Text;
                    string modelo = txt_modelo.Text;
                    if (etanol <= (gasolina * 0.7))
                    {
                        msg = $"O etanol está compensando para seu {marca} {modelo}.";
                    }
                    else
                    {
                        msg = $"A gasolina está compensando para seu {marca} {modelo}.";
                    }
                    DisplayAlert("Calculado", msg, "OK");
                }
                catch (Exception ex)
                {
                    DisplayAlert("Ops", ex.Message, "Fechar");
                }
            } // Fecha método
        } //Fecha Class
    } // Fecha namespace
}
