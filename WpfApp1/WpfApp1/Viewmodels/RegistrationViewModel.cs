using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1.Viewmodels
{
   public class RegistrationViewModel:INotifyPropertyChanged
    {
        public RegistrationViewModel()
        {
        
            BirthDate = new DateTime(2000,1,1);
        }
        private string _login;
        private string _password;
        private string _repassword;
        public string Login
        {
            get { return _login; }
            set
            {
                if (_login!=value)
                {
                    _login = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Login")); 
                }
            }
        }
        
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password!=value)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PasswordMatch"));
                }
            }
        }
       
        public string Re_Password
        {
            get { return _repassword; }
            set
            {
                if (_repassword != value)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Re_Password"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PasswordMatch"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PasswordMatchEnable"));
                }
            }
        }


        public bool TermsAccepted{ get; set; }
        public DateTime BirthDate { get; set; }

        public bool PasswordMAtch
        {
            get
            {
                return Password == Re_Password;
            }
        }

        public bool PasswordMatchEnable
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Password) && string.IsNullOrWhiteSpace(Re_Password);
            }
                
         }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
