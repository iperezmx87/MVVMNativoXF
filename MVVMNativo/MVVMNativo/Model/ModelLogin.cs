using MVVMNativo.MVVMCore;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMNativo.Model
{
    public class ModelLogin : NotifyPropertyChanged
    {
        private string _UserName;
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
                OnPropertyChanged("UserName");
            }
        }

        private string _Password;
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                OnPropertyChanged("Password");
            }
        }

        public NotifyTask<ObservableCollection<string>> LstFruits { get; set; }

        public ModelLogin()
        {
            LstFruits = new NotifyTask<ObservableCollection<string>>(LoadFruits());
        }

        private async Task<ObservableCollection<string>> LoadFruits()
        {
            await Task.Delay(5000);

            List<string> lstFuits = new List<string> {
                "Watermelon",
                "Strawberry",
                "Cherry",
                "Orange",
                "Lemon"
            };

            return new ObservableCollection<string>(lstFuits);
        }

        private Command _CmdLogin;
        public Command CmdLogin
        {
            get
            {
                if (_CmdLogin == null)
                {
                    _CmdLogin = new Command(() =>
                    {
                        App.Current.MainPage.DisplayAlert("MVVM", $"User Name: {UserName}", "Ok");
                    });
                }

                return _CmdLogin;
            }
        }
    }
}
