using System;
using System.Collections.Generic;
using System.IO;
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

namespace CSGOconfig
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();


        }

        void OnClick(object sender, RoutedEventArgs e)
        {
            config_box.Text = "";
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            string str = "unbindall\nbind \"0\" \"slot10\"\n";
            config_box.Text += str;
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            string actionbox = ActionBOX.Text;
            string buttonbox = ButtonBOX.Text;
            string first = null;
            string second = null;
            switch (actionbox)
            {
                case "Jumpthrow":
                    first = $"alias \" + jumpthrow\" \" + jump; -attack\"; alias \" - jumpthrow\" \" - jump\"\nbind {buttonbox} \"+jumpthrow\"";
                    break;
                default:
                    break;
            }

            string str = first + "\n";
            config_box.Text += str;
        }

        void OnClick4(object sender, RoutedEventArgs e)
        {
            var writer = new StreamWriter(File.OpenWrite("config.cfg"));
            writer.WriteLine(config_box.Text);
            writer.Close();
        }

        void OnClick5(object sender, RoutedEventArgs e)
        {
            faq.IsEnabled = false;
            Window1 win1 = new Window1();
            win1.Show();
            faq.IsEnabled = true;
        }

        void OnClick6(object sender, RoutedEventArgs e)
        {
            string str = CommandBOX.Text + "\n";
            config_box.Text += str;
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

        }
    }
}
