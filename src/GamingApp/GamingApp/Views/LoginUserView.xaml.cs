using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GamingApp.Interfaces;

namespace GamingApp.Views
{
    /// <summary>
    /// Interaction logic for LoginUserView.xaml
    /// </summary>
    public partial class LoginUserView : UserControl, IView
    {
        public LoginUserView()
        {
            InitializeComponent();
        }
    }
}
