using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            /*if (txt_altura == null)
            {
                await DisplayAlert("Atenção!", "Digite um valor válido", "OK");
            }
            else if (txt_peso == null)
            {
                await DisplayAlert("Atenção!", "Digite um valor válido", "OK");
            }*/

            double peso = Convert.ToDouble(txt_peso.Text);
            double altura = Convert.ToDouble(txt_altura.Text);

            double IMC = peso / (altura * altura);
            IMC = Math.Round(IMC, 2);

            //Pega o selecionado no picker
            int selectedIndex = pck_teste.SelectedIndex;
            string genero_selecionado = "";

            if (selectedIndex != -1)
            {
                genero_selecionado = pck_teste.Items[selectedIndex];
            }



            if (genero_selecionado == "Masculino")
            {
                if (IMC <= 20)
                {
                    await DisplayAlert("Atenção!", $"Seu peso está abaixo do normal\n Seu imc é de: {IMC}", "OK");
                }
                else if (IMC > 20 && IMC < 25)
                {
                    await DisplayAlert("Atenção!", $"Seu peso está normal\n Seu imc é de: {IMC}", "OK");
                }
                else if (IMC >= 25 && IMC < 30)
                {
                    await DisplayAlert("Atenção!", $"Grau de obesidade leve\n Seu imc é de: {IMC}", "OK");
                }
                else if (IMC >= 30 && IMC < 43)
                {
                    await DisplayAlert("Atenção!", $"Grau de obesidade moderada\n Seu imc é de: {IMC}", "OK");
                }
                else
                {
                    await DisplayAlert("Atenção!", $"Grau de obesidade mórbida\n Seu imc é de: {IMC}", "OK");
                }

            }

            if (genero_selecionado == "Feminino ❤")
            {
                if (IMC <= 19)
                {
                    await DisplayAlert("Atenção!", $"Seu peso está abaixo do normal\n Seu imc é de: {IMC}", "OK");
                }
                else if (IMC > 19 && IMC <= 24)
                {
                    await DisplayAlert("Atenção!", $"Seu peso está normal\n Seu imc é de: {IMC}", "OK");
                }
                else if (IMC > 24 && IMC < 29)
                {
                    await DisplayAlert("Atenção!", $"Grau de obesidade leve\n Seu imc é de: {IMC}", "OK");
                }
                else if (IMC >= 29 && IMC < 39)
                {
                    await DisplayAlert("Atenção!", $"Grau de obesidade moderada\n Seu imc é de: {IMC}", "OK");
                }
                else
                {
                    await DisplayAlert("Atenção!", $"Grau de obesidade mórbida\n Seu imc é de: {IMC}", "OK");
                }

            }

        }
    }
}
