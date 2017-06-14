using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HelpAnimals.ViewModels;


namespace HelpAnimals
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            BindingContext = new LoginViewModel();
        }
    }
}
