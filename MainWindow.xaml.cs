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
using MahApps.Metro.Controls;
namespace CSGOconfig
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {



        public MainWindow()
        {
            InitializeComponent();
            btn_preset.IsEnabled = false;

        }

        void OnClick(object sender, RoutedEventArgs e)
        {
            config_box.Text = "";
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
                case "Mousewheel Jump":
                    first = $"bind mwheelup +jump;bind mwheeldown +jump;bind space +jump";
                    break;
                case "Quickswitch":
                    first = $"bind {buttonbox} \"use weapon_knife;slo1\"";
                    break;
                case "Flashbang":
                    first = $"bind {buttonbox} \"use weapon_flashbang\"";
                    break;
                case "Smoke":
                    first = $"bind {buttonbox} \"use weapon_smokegrenade\"";
                    break;
                case "HE grenade":
                    first = $"bind {buttonbox} \"use weapon_hegrenade\"";
                    break;
                case "Molotov":
                    first = $"bind {buttonbox} \"use weapon_molotov;use weapon_incgrenade\"";
                    break;
                case "Drop Bomb":
                    first = $"bind {buttonbox} \"use weapon_knife; use weapon_c4; drop; slot1\"";
                    break;
                case "Clear Decals":
                    first = $"bind {buttonbox} \"r_cleardecals\"";
                    break;
                case "Switch Hands":
                    first = $"bind {buttonbox} \"toggle cl_righthand 0 1\"";
                    break;
                case "Remove Crosshair":
                    first = $"bind {buttonbox} \"toggle crosshair 0 1\"";
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
            MessageBox.Show("Successfuly saved to config.cfg");
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
