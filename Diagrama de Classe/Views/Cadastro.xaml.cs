using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App3
{
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
             Button continuar = new Button
            {
                Text = "Continuar",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("3bccc9")
            };
            Label texto2 = new Label
            {
                Text = "Entrar",
                TextColor = Color.FromHex("3bccc9"),
               
            };
            Label texto = new Label
            {
                Text = "Já tem uma conta?"
            };
            var datePicker = new DatePicker
            {
                //HorizontalOptions = LayoutOptions.Fill,
                //VerticalOptions = LayoutOptions.Center,
                
                Format = "yyyy/MM/dd",
                MinimumDate = new DateTime(1900, 01, 01),
                MaximumDate = new DateTime(2017, 12, 31)
            };

            var pick = new Picker
            {
               
            };

            pick.Items.Add("Masculino");
            pick.Items.Add("Feminino");
            InitializeComponent();
            StackLayout Layout = new StackLayout
            {
                Padding = 20,
                Spacing = 50,
                VerticalOptions = LayoutOptions.Center,
                
                Children =
                {
                    new Entry {Placeholder = "Endereço de Email" },
                    new Entry {Placeholder = "Senha"},
                    datePicker,
                    pick,
                    continuar,
                    
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            texto,
                            texto2,
                          
                        }
                    }
             
                }
            };
            this.Content = Layout;
            BackgroundColor = Color.White;

            var TapGesture = new TapGestureRecognizer();
            TapGesture.Tapped += (s, e) =>
             {
                 texto2.Navigation.PopAsync(); 
 
             };
            texto2.GestureRecognizers.Add(TapGesture);

        }
    }
}
