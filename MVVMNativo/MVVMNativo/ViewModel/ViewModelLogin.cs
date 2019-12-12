using MVVMNativo.Model;
using MVVMNativo.MVVMCore;

namespace MVVMNativo.ViewModel
{
    public class ViewModelLogin : NotifyPropertyChanged
    {
        private ModelLogin _Model;
        public ModelLogin Model
        {
            get
            {
                return _Model;
            }
            set
            {
                _Model = value;
                OnPropertyChanged("Model");
            }
        }

        public ViewModelLogin()
        {
            Model = new ModelLogin();
            Model.Password = "";
            Model.UserName = "";
        }
    }
}
