using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace HelpAnimals
{


    public class LoginViewModel : BaseViewModel
    {
        string email;
        string senha;

        string message = string.Empty;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(); }
        }

        public void TryLoginAsync()
        {
            CloudDataStore cloud = new CloudDataStore();
            cloud.Login(email, senha);
        }
    }
}
