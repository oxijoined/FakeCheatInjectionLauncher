using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Ui.Controls;
using Wpf.Ui.Extensions;

namespace Alteris
{
    /// <summary>
    /// Логика взаимодействия для LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Page
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            if (LoginInput.Text.Length == 0 || PasswordInput.Text.Length == 0)
            {
                SnackBar.Show("You have not filled in the fields");
            }
            else
            {
                CurrentGrid.Visibility = Visibility.Hidden;
                this.MainFrame.Content = new GameChoose();
            }
        }
    }
}
