

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace HelpAnimals.ViewModels
{


    class CadastroViewModel : BaseViewModel
    {
        private bool validLogin;
        private bool validPassword;
        private string _entryCadastroPassword;
        

        public string EntryCadastroPassword
        {
            get { return _entryCadastroPassword; }
            set
            {
                SetProperty(ref _entryCadastroPassword, value);

                if (_entryCadastroPassword != "")
                {
                    if (_entryCadastroPassword != null) validPassword = true;
                }
                else validLogin = false;
            }
        }



        private string _entryCadastroLogin;

        public string EntryCadastroLogin
        {
            get { return _entryCadastroLogin; }
            set
            {
                SetProperty(ref _entryCadastroLogin, value);
                if (EntryCadastroLogin != "")
                {
                    if (EntryCadastroLogin != null)
                        validLogin = true;
                }

            }
        }

        private string _entryDataNascimento;

        public string EntryDataNascimento
        {
            get { return _entryDataNascimento; }
            set
            {
                SetProperty(ref _entryDataNascimento, value);
            }
        }

        private string _nomeUsuario;

        public string EntryNomeUsuario
        {
            get { return _nomeUsuario; }
            set { SetProperty(ref _nomeUsuario, value); }
        }

        public Command CadastroCommand { get; private set; }
        public CadastroViewModel()
        {
            CadastroCommand = new Command(ExecuteCadastroCommand, canExecuteCadastroCommand);

        }
        bool canExecuteCadastroCommand()
        {
            if (validLogin && validPassword) return true;

            else return false;
        }
        void ExecuteCadastroCommand()
        {
            CloudDataStore cloud = new CloudDataStore();
            cloud.Cadastro(_nomeUsuario, _entryCadastroLogin, _entryCadastroPassword);
        }
    }
}