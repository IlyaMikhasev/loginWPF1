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
using System.Windows.Forms.Integration;
using System.Windows.Forms;

namespace loginWPF1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MaskedTextBox _mtb_mymask;
        string pass = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowsFormsHost host = new WindowsFormsHost();
           
            MaskedTextBox mtb_mymask = new MaskedTextBox();
            
            mtb_mymask.Name = "maskedTextBoxPassword";
            mtb_mymask.PasswordChar = '*';
            mtb_mymask.TabIndex = 1;
            mtb_mymask.BackColor = System.Drawing.Color.AliceBlue;
            mtb_mymask.Font =
                new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace,
                20F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(204)));
            _mtb_mymask = mtb_mymask;
            host.Child = _mtb_mymask;
            host.Width = 150;//размеры текст бокса 
            host.Height = 30;
            stack.Children.Add(host);
        }

        private void ShowPass(object sender, RoutedEventArgs e)
        {
            tb_password.Text = _mtb_mymask.Text;            
        }
       

        private void b_open_password_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            _mtb_mymask.PasswordChar = '\0';
        }

        private void b_open_password_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            _mtb_mymask.PasswordChar = '*';
        }

    
    }
}
