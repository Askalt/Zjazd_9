using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Model
{
    public class FakeDB
    {
        public bool AddUser(UserAccount uacc)
        {
            MessageBox.Show($"User has been added to db.", "Success", MessageBoxButton.OK);
            return true;
        }
    }
}
