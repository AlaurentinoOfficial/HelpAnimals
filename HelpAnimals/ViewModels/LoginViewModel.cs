using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace HelpAnimals
{


    public class LoginViewModel : BaseViewModel
    {

        string message = string.Empty;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(); }
        }

        private bool validLogin;
        private bool validPassword;
        private string _entryPassword;


        public string EntryPassword
        {
            get { return _entryPassword; }
            set
            {
                SetProperty(ref _entryPassword, value);

                if (_entryPassword != "")
                {
                    if (_entryPassword != null) validPassword = true;
                }
                else validLogin = false;
            }
        }



        private string _entryLogin;

        public string EntryLogin
        {
            get { return _entryLogin; }
            set
            {
                SetProperty(ref _entryLogin, value);
                if (EntryLogin != "")
                {
                    if (EntryLogin != null)
                        validLogin = true;
                }

            }
        }



        public Command LoginCommand { get; private set; }
        public Command ChangeScreen { get; private set; }
        public LoginViewModel()
        {
            LoginCommand = new Command(ExecuteLoginCommand, canExecuteLoginCommand);
            //ChangeScreen = new Command(ExecuteChangeScreenCommand);
        }


        bool canExecuteLoginCommand()
        {
            if (validLogin && validPassword) return true;

            else return false;
        }
        void ExecuteLoginCommand()
        {
            CloudDataStore cloud = new CloudDataStore();
            cloud.Login(_entryLogin, _entryPassword);
        }
        
    }
}
