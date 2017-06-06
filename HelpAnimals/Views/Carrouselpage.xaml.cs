using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App3
{
    public partial class Carrouselpage : CarouselPage
    {
        public Carrouselpage()
        {
            InitializeComponent();
            
        
        }
        protected async void OnClicked(object sender,EventArgs args)
        {
            await Navigation.PushAsync(new Menu()); 
        }
    }

}
